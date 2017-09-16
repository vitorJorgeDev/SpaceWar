using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ObjetosCamera  {

	public static bool estaVisivel(this Renderer renderer, Camera camera)
	{
		Plane[] planos = GeometryUtility.CalculateFrustumPlanes (camera);
		return GeometryUtility.TestPlanesAABB (planos, renderer.bounds);
	}

}
