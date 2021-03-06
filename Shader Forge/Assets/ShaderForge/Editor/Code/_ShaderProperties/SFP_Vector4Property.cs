using UnityEngine;
using System.Collections;

namespace ShaderForge {

	[System.Serializable]
	public class SFP_Vector4Property : SF_ShaderProperty {


		public bool isBumpmap = false;

		public new SFP_Vector4Property Initialize( SF_Node node ) {
			base.nameType = "Vector 4";
			base.Initialize( node );
			return this;
		}

		public override string GetInitializationLine() {
			return GetTagString() + GetVariable() + " (\"" + nameDisplay + "\", Vector) = (" + GetValue().r + "," + GetValue().g + "," + GetValue().b + "," + GetValue().a + ")";
		}

		Color GetValue() => ( node as SFN_Vector4Property ).texture.dataUniform;

		public override string GetCGType() => node.precision.ToCode() + "4";

	}
}