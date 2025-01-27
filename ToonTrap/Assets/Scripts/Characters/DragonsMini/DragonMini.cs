using Ryocatusn.Audio;
using Ryocatusn.Janken;
using Ryocatusn.Janken.AttackableObjects;
using Ryocatusn.Janken.JankenableObjects;
using Ryocatusn.Photographers;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using Zenject;

namespace Ryocatusn.Characters
{
    public class DragonMini : JankenBehaviour, IReceiveAttack, IForJankenViewEditor, IPhotographerSubject
    {
        [SerializeField]
        public Hand.Shape shape;
        [SerializeField, Min(1)]
        private int atk = 1;
        [SerializeField, Min(0)]
        private float attackRange;
        [SerializeField]
        [Min(0)]
        private float attackWaitTime = 0;

        [Inject]
        private StageManager stageManager;
        [Inject]
        private DiContainer container;

        [Inject]
        private BulletFactory bulletFactory;
        [SerializeField]
        private Bullet bullet;

        [SerializeField]
        private JankenPrefabs jankenPrefabs;
        private DragonMiniView dragonView;

        [SerializeField]
        private SE attackSE;

        private Player player;

        public bool isAllowedToReceiveAttack { get; set; } = true;

        public int priority { get; } = 0;

        public int photographerCameraSize { get; } = 2;

        public Subject<Unit> showOnPhotographerEvent { get; }

        [Inject]
        private PhotographerSubjectManager photographerSubjectManager;


        private void Start()
        {
            Create(new Hp(1), shape);

            player = gameManager.gameContains.player;

            stageManager
                .SetupStageEvent
                .Subscribe(_ =>
                {
                    dragonView.SetUp();
                })
                .AddTo(this);

            dragonView.AttackTriggerEvent
            .Subscribe(_ => AttackTrigger())
            .AddTo(this);

            events.AttackTriggerEvent
            .Subscribe(x => HandleAttackTrigger(x.id))
            .AddTo(this);

            events.DieEvent
            .Subscribe(_ => HandleDie())
            .AddTo(this);

            SEPlayer sePlayer = new SEPlayer(gameObject, gameManager.gameContains.gameCamera);

            events.AttackTriggerEvent.Subscribe(_ => sePlayer.Play(attackSE)).AddTo(this);

            stageManager.SetupStageEvent
                .Subscribe(_ =>
                {
                    float lastTimeAttack = 0;
                    this.UpdateAsObservable()
                    .Subscribe(_ =>
                    {
                        if (dragonView.IsVisible() && player != null && Vector2.Distance(transform.position, player.transform.position) <= attackRange && Time.fixedTime - lastTimeAttack > attackWaitTime)
                        {
                            lastTimeAttack = Time.fixedTime;
                            dragonView.StartAttackAnimation();
                        }
                    });
                })
                .AddTo(this);

            photographerSubjectManager.Save(this);
        }
        private void OnDestroy()
        {
            photographerSubjectManager.Delete(this);
        }

        private void AttackTrigger()
        {
            AttackableObjectCreateCommand command = new AttackableObjectCreateCommand(id, GetData().shape, new Atk(atk));
            AttackTrigger(command);
        }

        private void HandleAttackTrigger(AttackableObjectId id)
        {
            if (player != null) bulletFactory.Create(bullet, id, gameObject, dragonView.shotPoint.transform.position, player.transform);
            else bulletFactory.Create(bullet, id, gameObject, dragonView.shotPoint.transform.position, dragonView.shotPoint.transform.rotation);
        }

        private void HandleDie()
        {
            Destroy(gameObject);
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, attackRange);
        }

        public JankenableObjectId GetId()
        {
            return id;
        }

        public Hand.Shape GetShape()
        {
            return shape;
        }
        public void UpdateView(Hand.Shape shape)
        {
            if (jankenPrefabs.TryGetRenderer(out GameObject gameObject, this))
            {
                for (int i = 0; i < transform.childCount; i++)
                {
                    if (Application.isPlaying) Destroy(transform.GetChild(i).gameObject);
                    else DestroyImmediate(transform.GetChild(i).gameObject);
                }
                GameObject prefab = jankenPrefabs.GetAsset(shape);
                GameObject newGameObject = Instantiate(prefab, gameObject.transform);
                if (container != null) container.InjectGameObject(newGameObject);
                dragonView = newGameObject.GetComponent<DragonMiniView>();

                foreach (ReceiveAttackChild receiveAttackChild in GetComponentsInChildren<ReceiveAttackChild>())
                {
                    receiveAttackChild.jankenBehaviour = this;
                }
            }
        }

        public Vector3 GetPosition()
        {
            return transform.position;
        }
    }
}
