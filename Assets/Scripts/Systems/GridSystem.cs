using Unity.Entities;

public class GridSystem : SystemBase
{
    struct GridUpdate : IComponentData
    {
    }

	protected override void OnCreate()
	{
	}

	protected override void OnUpdate()
    {
        Entities.ForEach(() => {
        }).Schedule();
    }
}
