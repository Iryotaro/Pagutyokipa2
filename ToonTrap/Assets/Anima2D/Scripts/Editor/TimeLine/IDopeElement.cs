﻿namespace Anima2D
{
    public interface IDopeElement
    {
        float time { get; set; }

        void Flush();
    }
}
