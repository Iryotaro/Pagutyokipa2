using Ryocatusn.Games;
using Ryocatusn.Janken;
using Ryocatusn.Janken.AttackableObjects;
using Ryocatusn.Janken.JankenableObjects;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using Zenject;

namespace Ryocatusn.Characters
{
    public class JankenBehaviour : MonoBehaviour
    {
        public JankenableObjectId id { get; private set; }
        public JankenableObjectEvents events { get; private set; }

        [Inject]
        protected JankenableObjectApplicationService jankenableObjectApplicationService { get; }
        [Inject]
        protected CharacterManager characterManager;
        [Inject]
        protected GameManager gameManager;

        protected void Create(Hp hp, InvincibleTime invincibleTime, Hand.Shape shape)
        {
            JankenableObjectCreateCommand command = new JankenableObjectCreateCommand(hp, invincibleTime, shape);
            Create(command);

            this.OnDestroyAsObservable()
                .Subscribe(_ =>
                {
                    if (jankenableObjectApplicationService == null) return;
                    jankenableObjectApplicationService.Delete(id);
                    characterManager.Delete(id);
                });
        }
        protected void Create(Hp hp, Hand.Shape shape)
        {
            JankenableObjectCreateCommand command = new JankenableObjectCreateCommand(hp, shape);
            Create(command);
        }
        private void Create(JankenableObjectCreateCommand command)
        {
            id = jankenableObjectApplicationService.Create(command);
            events = jankenableObjectApplicationService.GetEvents(id);

            characterManager.Save(this);

            this.OnDestroyAsObservable()
                .Subscribe(_ => jankenableObjectApplicationService.Delete(id));
        }

        protected JankenableObjectData GetData()
        {
            return jankenableObjectApplicationService.Get(id);
        }
        protected void AttackTrigger(AttackableObjectCreateCommand command, IReceiveAttack[] receiveAttacks = null)
        {
            jankenableObjectApplicationService.AttackTrigger(id, command, receiveAttacks);
        }
        protected void AttackTrigger(AttackableObjectCreateCommand command, IReceiveAttack receiveAttack)
        {
            jankenableObjectApplicationService.AttackTrigger(id, command, new IReceiveAttack[] { receiveAttack });
        }
    }
}
