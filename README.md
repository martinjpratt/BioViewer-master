# BioViewer-master
Unity3D HoloLens Application for loading and viewing PDB files

Providing an initial platform for loading, displaying and interacting with Protein DataBase (PDB) models. The models
themselves have been exported from PyMol to Blender, where mesh editing has removed duplicate vertices included within the
exported VRML file. This allows for smoother surfaces to be rendered.

Model prefabs are saved as AssetBundles and stored on a Microsoft Azure Storage Account Blob (apologies if this goes out of
service).

You may need to change the shader/material on the menu buttons. Click the image below for an example video:

[![BioViewer](https://i.ytimg.com/vi/U493hmdUGW4/hqdefault.jpg?sqp=-oaymwEXCPYBEIoBSFryq4qpAwkIARUAAIhCGAE=&rs=AOn4CLBFy-OhT-NXhpw9lVD3KzW-enHdzw)](https://www.youtube.com/embed/U493hmdUGW4 "BioViewer")
