using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public class GridAuthoring : MonoBehaviour, IConvertGameObjectToEntity
{
	[SerializeField] int width = 10;
	[SerializeField] int height = 10;

	public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
	{
		var grid = new Grid
		{
			Width = width,
			Height = height
		};

		dstManager.SetComponentData(entity, grid);

		var buffer = dstManager.AddBuffer<Cell>(entity);
		for (int w = 0; w < width; w++)
		{
			for (int h = 0; h < height; h++)
				buffer.Add(new Cell
				{
					Coordinate = math.int2(w, h),
					Value = Entity.Null
				});
		}
	}
}
