using System;
using Unity.Entities;

[Serializable]
public struct Grid : IComponentData
{
	public int Width;
	public int Height;
}
