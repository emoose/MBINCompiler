# coding: UTF-8

bl_info = {
    "name": "Import EXML from NMS MBINCompiler",
    "author": "Elementia",
    "version": (1, 0, 0),
    "blender": (2, 77, 0),
    "location": "File > Import > NMS EXML",
    "description": "Imports exml models extracted from no man's sky.",
    "wiki_url": "https://github.com/emoose/MBINCompiler",
    "category": "Import-Export"
}

import os.path
import bpy

from bpy_extras.io_utils import ImportHelper
from bpy.props import StringProperty, BoolProperty
from bpy.types import Operator

from xml.etree import cElementTree as ElementTree

def getProperty(node, name):
    for p in node:
        if 'name' in p.keys() and p.get('name')==name:
            return p
    return null
    
def getFloatList(node):
    list = []
    for p in node:
        list.append(float(p.get('value').replace(",", ".")))
    return list
    
def getIntList(node):
    list = []
    for p in node:
        list.append(int(p.get('value')))
    return list;

class ImportEXML(Operator, ImportHelper):
    """Imports EXML """
    bl_idname = "import_model.exml"
    bl_label = "Import EXML"
    bl_options = {'REGISTER', 'UNDO'}

    filter_glob = StringProperty(default="*.exml", options={'HIDDEN'})

    def execute(self, context):
        xmlRoot = ElementTree.parse(self.filepath).getroot()
        
        vertices = []
        normals = []
        edges = []
        faces = []
        
        # Extract data from vertex stream
        nbVertices = int(getProperty(xmlRoot, 'VertexCount').get('value'))
        vertexData = getFloatList(getProperty(xmlRoot, 'VertexStream'))
        stride = int(int(getProperty(getProperty(xmlRoot, 'VertexLayout'), 'Stride').get('value'))/2);
        
        
        for i in range(0, nbVertices):
            vert = (vertexData[i*stride], vertexData[i*stride+2], vertexData[i*stride+1])
            norm = [vertexData[i*stride+4], vertexData[i*stride+6], vertexData[i*stride+5]]
            vertices.append(vert)
            normals.append(norm)
        
        
        # Extract Faces
        indexData = getIntList(getProperty(xmlRoot, 'IndexBuffer'))
        nbFaces = int(len(indexData)/3)
        
        for i in range(0, nbFaces):
            face = (indexData[i*3], indexData[i*3+1], indexData[i*3+2])
            faces.append(face)
        
        # Create mesh
        mesh = bpy.data.meshes.new("mesh001")
        mesh.from_pydata(vertices, edges, faces)
        mesh.update()
        
        # Set normals to the mesh
        normals2 = []
        for l in mesh.loops:
            normals2.append(normals[l.vertex_index])
        mesh.normals_split_custom_set(normals2)
        
        # Create object
        obj = bpy.data.objects.new(name="obj001", object_data=mesh)
        obj.location = (0, 0, 0)
        bpy.context.scene.objects.link(obj)
        
        # Define vertex groups
        grpStart = getIntList(getProperty(xmlRoot, 'MeshVertRStart'))
        grpEnd = getIntList(getProperty(xmlRoot, 'MeshVertREnd'))
        
        for i in range(0, len(grpStart)):
            grp = obj.vertex_groups.new("group_"+str(i))
            grp.add(range(grpStart[i], grpEnd[i]+1), 1.0, 'REPLACE')
        
        return {'FINISHED'}

def menu_func_import(self, context):
    self.layout.operator(ImportEXML.bl_idname, text="Import EXML (.exml)")

def register():
    bpy.utils.register_class(ImportEXML)
    bpy.types.INFO_MT_file_import.append(menu_func_import)

def unregister():
    bpy.utils.unregister_class(ImportEXML)
    bpy.types.INFO_MT_file_import.remove(menu_func_import)

if __name__ == "__main__":
    try:
        unregister()
    except:
        pass
    register()