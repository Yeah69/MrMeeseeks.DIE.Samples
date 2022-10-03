using MrMeeseeks.DIE.Configuration.Attributes;

namespace MrMeeseeks.DIE.Samples.GettingStarted;

[ImplementationAggregation(
    typeof(Logger), 
    typeof(MrMeeseeks))]

[CreateFunction(typeof(MrMeeseeks), "Create")]
internal sealed partial class Container
{
    
}