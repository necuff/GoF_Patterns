using CompositePattern_experimant.Components;

Folder f = new Folder("root");
Folder f2 = new Folder("D");
CompositePattern_experimant.Components.File file1 = new CompositePattern_experimant.Components.File("file1");
CompositePattern_experimant.Components.File file2 = new CompositePattern_experimant.Components.File("file2");
CompositePattern_experimant.Components.File file3 = new CompositePattern_experimant.Components.File("file3");

f.Add(f2);
f.Add(file1);
f.Add(file3);
f2.Add(file2);


f.ShowDirectory();