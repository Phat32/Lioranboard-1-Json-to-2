# Lioranboard 1 Json to 2
A WPF tool to convert the exported JSON from Lioranboard 1 to the format used in Lioranboard 2

# This tool is a work in progress
So far it seems to be working as expected but not everything has been fully tested. Please save often and check the buttons in LB2 before going too far and please report any issues you run across

# Usage
Super simple, download the latest [release](https://github.com/Phat32/Lioranboard-1-Json-to-2/releases) (currently 0.0.10 at time of writing)

Extract the contents and run **Lioranboard 1 Json to 2.exe**

The tool itself is super straight forward, 2 boxes and 2 buttons and a checkbox

![Screnshot of the tool](https://user-images.githubusercontent.com/10120690/156736325-43b69612-82f8-461c-8eb0-cb8f2a262842.png)


Open Lioranboard 1 and find the button you want to copy to LB2, right click it and select **Export JSON** just near the bottom

***NOTE:** While here make sure you have already upgraded from the depreated **Compare** commands to the **Statement** commands. This can be done in LB1 easily by selecting "Auto Replace 'Compare' to 'Statement'" in the top of the deck and opening each button one by one. This will automatically convert the Compare to Statement as the option suggests. If this step is not done Compare statements are exported they will import to LB2 as a comment alerting that command does not convert.*

![Screenshot of Lioranboard 1](https://user-images.githubusercontent.com/10120690/156732790-ac589a32-36af-4d89-be7d-684b674a275f.png)

With the exported button in your clipboard, paste that into the top text box above the Convert button. Press **Convert JSON** and in a moment it will produce the converted JSON into the bottom window. A message will alert popup letting you know the conversion is complete and a reminder to double check the buttons functioning in LB2.

![Screenshot of the copied JSON in LB1to2](https://user-images.githubusercontent.com/10120690/156736684-aa2c5d1e-102c-4ea1-a603-cf8b8a54b3bc.png)


The converted JSON will be automatically copied to your clipboard and displayed in the bottom window. Take this new JSON and import the JSON into LB2

To convert another button either press the Clear JSON button or replace the text in the first box with the new JSON and press convert again, it will replace the text in the converted box.

If you're mass converting buttons the popup can get rather annoying rather quickly, so a checkbox has been added to disable the popup. All warnings are still in effect of course.



