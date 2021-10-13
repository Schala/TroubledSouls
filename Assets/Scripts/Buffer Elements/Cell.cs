using Unity.Entities;
using Unity.Mathematics;

/// <summary>
/// A single cell on our game grid
/// </summary>
[InternalBufferCapacity(100)]
public struct Cell : IBufferElementData
{
	public int2 Coordinate;
	public Entity Value;

	public static implicit operator Entity(Cell c) => c.Value;
}
