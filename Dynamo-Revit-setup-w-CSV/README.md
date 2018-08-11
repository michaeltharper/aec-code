# csv-setup

Adaptation of Dynamo code in Lynda Project Setup to use CSV instead of Microsoft Excel spreadsheets: 
https://www.lynda.com/Dynamo-Studio-tutorials/Dynamo-Revit-Project-Setup/586670-2.html

The Dynamo 1.3.x node: 
Office.Excel.ReadFromFile

Can see valid .xls or .xlsx files on the file system, but not open.
Apparently relies on local installation of Microsoft Excel:
  Warning: Excel.ReadFromFile operation failed. 
  Excel is not installed.
  
  
OpenOffice is installed and set as default for .xls, but Dynamo doesn't hand off.
  
This node can open a CSV file:
  Core.CSV.ReadFromFile
but CSV doesn't seem to support multi-sheet layouts, so need to break muti-sheet XLS into individual sheets? or open with list handing?


