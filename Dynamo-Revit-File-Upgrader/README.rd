# Revit File Upgrader

Dynamo graph to:
open all Revit files in target directory with Audit and Detach from Central, 
upgrade to current Revit version, 
close and save.

Uses these Rhythm calls:
Rhythm.Revit.Application.Applications.OpenDocumentFile
Rhythm.Revit.Application.Applications.CloseDocument