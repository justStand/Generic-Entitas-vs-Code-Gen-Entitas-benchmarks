//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeGenSample
{
    public sealed partial class GameMatcher
    {

        public static Entitas.IAllOfMatcher<GameEntity> AllOf(params int[] indices)
        {
            return Entitas.Matcher<GameEntity>.AllOf(indices);
        }

        public static Entitas.IAllOfMatcher<GameEntity> AllOf(params Entitas.IMatcher<GameEntity>[] matchers)
        {
            return Entitas.Matcher<GameEntity>.AllOf(matchers);
        }

        public static Entitas.IAnyOfMatcher<GameEntity> AnyOf(params int[] indices)
        {
            return Entitas.Matcher<GameEntity>.AnyOf(indices);
        }

        public static Entitas.IAnyOfMatcher<GameEntity> AnyOf(params Entitas.IMatcher<GameEntity>[] matchers)
        {
            return Entitas.Matcher<GameEntity>.AnyOf(matchers);
        }
    }
}