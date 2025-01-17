# Model Tracker | Watcher Uploader
A key part of Iso's functionality is to track data within a Revit session so that one can granularly understand how modelers are modeling and what is occurring within `Phase 4` of IPX's *Life of An Order*.

### Why Does This Matter
1. Realtime updates on Modelling tracking activities.
2. The  separation of threads and independence ensures Revit does not lag/load when uploading tracked data.
3. The uploading process of tracked data continues even when Revit is closed or it crashes


### What Does This Do?
This is one of a two-part system for tracking modeler activity:
1. The first part, the *DataCollector* collects all relevant data from Revit writes to a csv file (@symonkipkemei is actively working on this)
2. The second part, the *WatcherUploader* tracks any changes on the csv file and json file independently & uploads the data to airtable (@prestonsmithII is actively working on this)

### Setup
- Pull the code from Github
- To run, you should use the commandline to enter `dotnet run <args>`
- Available arguments, or `args` are:
  * 1. --generateFakeData (no value necessary) - generates fake data
  * 2. --pathToCSV="path/to/csv" - the path to the CSV data you'd like to watch and upload from
  * 3. --pathToJSON="path/to/json" - the path to the JSON data you'd like to watch and stream status to/from
  * 4. --simulateRandomData (no value necessary) - new! will simulate new data being added to your CSV randomly throughout the process

- When running, if you'd like to generate fake data to test things out you can pass an argument `--generateFakeData --simulateRandomData` which will automatically generate CSV and JSON data for the program to use on the fly without any other necessary arguments
