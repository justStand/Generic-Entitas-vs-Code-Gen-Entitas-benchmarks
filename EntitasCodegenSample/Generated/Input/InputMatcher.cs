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



    public sealed partial class InputMatcher
    {

        public static Entitas.IAllOfMatcher<InputEntity> AllOf(params int[] indices)
        {
            return Entitas.Matcher<InputEntity>.AllOf(indices);
        }

        public static Entitas.IAllOfMatcher<InputEntity> AllOf(params Entitas.IMatcher<InputEntity>[] matchers)
        {
            return Entitas.Matcher<InputEntity>.AllOf(matchers);
        }

        public static Entitas.IAnyOfMatcher<InputEntity> AnyOf(params int[] indices)
        {
            return Entitas.Matcher<InputEntity>.AnyOf(indices);
        }

        public static Entitas.IAnyOfMatcher<InputEntity> AnyOf(params Entitas.IMatcher<InputEntity>[] matchers)
        {
            return Entitas.Matcher<InputEntity>.AnyOf(matchers);
        }
    }
}