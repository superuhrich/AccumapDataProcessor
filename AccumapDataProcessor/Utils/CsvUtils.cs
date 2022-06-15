using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using CsvHelper;
using Geolocation;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;


namespace AccumapDataProcessor.Utils; 

public static class CsvUtils {

    /// <summary>
    /// Reads from a csv file of locations and returns them as an includes string for sql ingestion. 
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
    public static string ConvertUwiFromCsvToSqlString(string filePath) {
        // Get the list from the CSV
        var locationList = File.ReadAllLines(filePath, Encoding.UTF8);
        
        // Put it in teh format that is needed for sql. 
        for (var i = 0; i < locationList.Count(); i++) {
            // Remove hypens and slashes
            locationList[i] = Regex.Replace(locationList[i], @"[^0-9a-zA-Z]+", String.Empty);
            // Add 1 at the beginning
            locationList[i] = locationList[i].Insert(0, "1");
        }
        
        if (!locationList.Any()) {
            MessageBox.Show("Please select a file with more than 0 UWI's");
            return "";
        }
        else {
            var locationString = "";
            foreach (var location in locationList) {
                locationString = locationString + $"\'{location}\',";
            }
            //Remove the last comma
            locationString = locationString.Remove(locationString.Length - 1, 1);
            return locationString;
        }
    }
}

