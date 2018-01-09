namespace CodeGenSample
{
    using Entitas;

    public class MoveSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _group;

        public MoveSystem(Contexts contexts)
        {
            _group = contexts.game.GetGroup(
                GameMatcher.AllOf(
                    GameMatcher.CodeGenPosition,
                    GameMatcher.CodeGenPosition
                )
            );
        }

        public void Execute()
        {
            foreach (var entity in _group.GetEntities())
            {
                var position = entity.codeGenPosition;
                var velocity = entity.codeGenVelocity;
                //const float dt = 1.0f / 60.0f;

                //entity.ReplaceCodeGenPosition(position.Location + velocity.Linear * dt,
                //    position.Rotation + velocity.Angular * dt);
            }
        }
    }
}