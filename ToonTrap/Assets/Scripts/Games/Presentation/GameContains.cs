﻿using Ryocatusn.Characters;
using Ryocatusn.Conversations;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Ryocatusn
{
    public class GameContains
    {
        public Player player { get; }
        public PlayerBody playerBody { get; }
        public GameCamera gameCamera { get; }
        public Light2D globalLight { get; }
        public AudioSource bgm { get; }
        public Conversation conversation { get; }

        public GameContains
            (
            Player player,
            PlayerBody playerBody,
            GameCamera gameCamera,
            Light2D globalLight,
            AudioSource bgm,
            Conversation conversation
            )
        {
            this.player = player;
            this.playerBody = playerBody;
            this.gameCamera = gameCamera;
            this.globalLight = globalLight;
            this.bgm = bgm;
            this.conversation = conversation;
        }
    }
}
