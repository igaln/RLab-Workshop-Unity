﻿/************************************************************************************

Depthkit Unity SDK License v1
Copyright 2016-2018 Scatter All Rights reserved.  

Licensed under the Scatter Software Development Kit License Agreement (the "License"); 
you may not use this SDK except in compliance with the License, 
which is provided at the time of installation or download, 
or which otherwise accompanies this software in either electronic or hard copy form.  

You may obtain a copy of the License at http://www.depthkit.tv/license-agreement-v1

Unless required by applicable law or agreed to in writing, 
the SDK distributed under the License is distributed on an "AS IS" BASIS, 
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
See the License for the specific language governing permissions and limitations under the License. 

************************************************************************************/

using UnityEngine;
using System.Collections;

namespace Depthkit
{
    /// <summary>
    /// ZeroDaysLookOccludeLayer adds a layer to render a transparency enabled DK clip projection.
    /// <summary>
    [System.Serializable]
    [DisallowMultipleComponent]
    public class Depthkit_ZeroDaysLookOccludeLayer : Depthkit_ZeroDaysLookLayer
    {

        private Material _selfOccludeMaterial;

        /// <summary>
        /// Submits the mesh for rendering
        /// <summary>
        public override void Draw(Matrix4x4 transform, Material material)
        {
            
            if (_geometryDirty || _mesh == null)
            {
                BuildMesh();
                _geometryDirty = false;
            }

            // even if opacity is 0, render to depth incase layers above require depth occlusion
            if (isActiveAndEnabled)
            {
                Graphics.DrawMesh(_mesh, transform, material, 0);
            }
        }

        new protected void OnEnable()
        {
            base.OnEnable();
            //Don't show this in the editor
            hideFlags = HideFlags.HideInInspector;
        }

        /// <summary>
        /// Rebuilds the mesh with the current settings
        /// <summary>
        public void BuildMesh()
        {

            if (_mesh == null)
            {
                _mesh = new Mesh();
            }

            ParentRenderer.GetMeshLattice (ref _mesh);
        }

        /// <summary>
        /// Gets the default shader name for this layer
        /// <summary>
        protected override string DefaultShaderString()
        {
            return "Depthkit/ZeroDaysLookOcclude";
        }
    }
}