# Revit File Upgrader

Dynamo graph to:
open all Revit files in target directory with Audit and Detach from Central, 
upgrade to current Revit version, 
close and save.

Uses these Rhythm calls:
Rhythm.Revit.Application.Applications.OpenDocumentFile
Rhythm.Revit.Application.Applications.CloseDocument


# ----------
VERSIONS
Revit-File-Upgrader-v0.9.01.dyn
Add logic for inner folder, which will upgrade files in multiple sub-folders, 
BUT not in sub-sub-folders, etc.  
Needs recursion logic, but Directory.Contents output "directories" cannot be input for its own "directory" input.

Revit-File-Upgrader-v0.8.dyn
Initial posting.  Upgrades all Revit .rvt files in a folder, saving earlier as .000?.rvt

