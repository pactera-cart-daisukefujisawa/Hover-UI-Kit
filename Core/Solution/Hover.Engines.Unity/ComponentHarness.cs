﻿using UnityEngine;

namespace Hover.Engines.Unity {

	/*================================================================================================*/
	public class ComponentHarness<T> : MonoBehaviour where T : IComponent, new() {

		public T Component { get; private set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ComponentHarness() {
			Component = new T();
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public void Awake() {
			Component.OnBegin();
		}

		/*--------------------------------------------------------------------------------------------*/
		public void Start() {
			Component.OnBegin();
		}

		/*--------------------------------------------------------------------------------------------*/
		public void Update() {
			Component.OnDisplayStep();
		}

		/*--------------------------------------------------------------------------------------------*/
		public void FixedUpdate() {
			Component.OnPhysicsStep();
		}

		/*--------------------------------------------------------------------------------------------*/
		public void OnDestroy() {
			Component.OnDestroy();
		}

	}

}
