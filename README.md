# bntu.vsrpp.vmisyakova
**Lab01 — "Visual Tools for Application Development". XML Parser**  
The task is to read a user-selected XML file with a simple structure (a list of objects) and display the number of objects in the file. The user should be able to perform the following operations on the parsed data:
* Maximum value
* Minimum value
* Average value
* Average string length
* Minimum string length
* Maximum string length  
When an operation is selected, the application must show a list of object fields for which the operation is applicable. A field is considered applicable only if it exists in all objects and has the same data type (e.g., the score field must be numeric in all objects).  
Optionally, the user can normalize the structure of the objects in the XML file. This includes:
1. If an object has a child element named FIO or FullName, split it into FirstName, LastName, and Surname.
2. Add missing fields in all objects: use "N/A" for strings and 0 for numeric fields.
3. Save the updated XML content to a new file named <original_filename>_output.xml.  
**Lab02 — "Visual Tools for Application Development". Currency Converter**
1. The application must use official currency exchange rates obtained from the website of the National Bank of the Republic of Belarus.
2. Users should be able to view exchange rates for all available currencies.
3. The application must support the following conversions:
* BYN → foreign currency
* Foreign currency → BYN
* Currency → Currency (via BYN as intermediary)
4. Optionally, the user can:
* Generate a chart of currency rate changes over a selected time period
* Determine the date when the rate was at its minimum/maximum
* Calculate the average exchange rate for the selected period

