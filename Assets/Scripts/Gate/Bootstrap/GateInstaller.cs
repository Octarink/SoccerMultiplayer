﻿using Gate.Factories;
using Gate.Services;
using UnityEngine;
using Zenject;

namespace Gate.Bootstrap
{
    public class GateInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.Bind<GateFactory>().AsSingle().NonLazy();
            Container.Bind<GateService>().AsSingle().NonLazy();
        }
    }
}