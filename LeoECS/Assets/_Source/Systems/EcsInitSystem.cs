using Leopotam.EcsLite;
using UnityEngine;

namespace Client 
{
    sealed class EcsInitSystem : IEcsInitSystem, IEcsRunSystem
    {
        private EcsFilter _filter;
        private EcsPool<EcsComponent> _entityPool;
        
        public void Init(IEcsSystems systems)
        {
            EcsWorld world = systems.GetWorld();
            _filter = world.Filter<EcsComponent>().End();
            _entityPool = world.GetPool<EcsComponent>();
        }

        public void Run(IEcsSystems systems)
        {
            foreach (int entity in _filter)
            {
                ref EcsComponent testComponent = ref _entityPool.Get(entity);
                ref var tra = ref testComponent.Anchor;
                tra.position += tra.forward;
                if (tra.position.x >= 1)
                {
                    tra.rotation = Quaternion.Euler(0, -60, 0);
                }
                else if (tra.position.x <= -1)
                {
                    tra.rotation = Quaternion.Euler(0, 60, 0);
                }
                
                ref var floatCounter = ref testComponent.Counter;
                floatCounter++;
                Debug.Log(floatCounter);
            }
        }
    }
}