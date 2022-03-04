# Lioranboard 1 Json to 2
A WPF tool to convert the exported JSON from Lioranboard 1 to the format used in Lioranboard 2

# This tool is a work in progress
So far it seems to be working as expected but not everything has been fully tested. Please save often and check the buttons in LB2 before going too far and please report any issues you run across

# Usage
Super simple, download the latest [release](https://github.com/Phat32/Lioranboard-1-Json-to-2/releases) (currently 0.0.8 at time of writing)

Extract the contents and run **Lioranboard 1 Json to 2.exe**

The tool itself is super straight forward, 2 boxes and 1 button.

![Screnshot of the tool, 2 text boxes with a button in the middle](https://user-images.githubusercontent.com/10120690/156732853-263a0662-1d1a-4118-9c88-f955597de826.png)

Open Lioranboard 1 and find the button you want to copy to LB2, right click it and select **Export JSON** just near the bottom

![Screenshot of Lioranboard 1](https://user-images.githubusercontent.com/10120690/156732790-ac589a32-36af-4d89-be7d-684b674a275f.png)


***NOTE:** While here make sure you have already upgraded from the depreated **Compare** commands to the **Statement** commands. This can be done in LB1 easily by selecting "Auto Replace 'Compare' to 'Statement'" in the top of the deck and opening each button one by one. This will automatically convert the Compare to Statement as the option suggests. If this step is not done Compare statements are exported they will import to LB2 as a comment alerting that command does not convert.*

With the exported button in your clipboard, paste that into the top text box above the Convert button. Press **Convert JSON** and in a moment it will produce the converted JSON into the bottom window. A message will alert popup letting you know the conversion is complete and a reminder to double check the buttons functioning in LB2.

![Screenshot of the copied JSON in LB1to2](https://user-images.githubusercontent.com/10120690/156732631-52670dad-1af5-41b8-9055-376efec29812.png)

Just copy the converted JSON (the bottom box is read only) and import the JSON into LB2

To convert another button simply replace the text in the first box with the new JSON and press convert again, it will replace the text in the converted box.



