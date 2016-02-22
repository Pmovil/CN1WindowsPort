#CN1WindowsPort
Windows RT port to Codename One

This port targets the newest windows devices. You will need Visual Studio to compile and test it.

#Current Status

- Currently it supports most of the core cn1 features
- There are already some apps in the stores using this port and it performs better than the official one, but it should be considered in beta stage, use it at your own risk

#Before you begin

send a windows build with sources included

#Installation

##step one

- Open Visual Studio
- Create New Project
- Templates > Visual C# > Store Apps >	Windows Phone Apps > Blank App(Windows Phone)
- Enter its name and click the OK button
- Delete App.xaml and MainPage.xaml

##step two

- Right-click References in the Solution Explorer
- Select Manage Nuget Packages
- Install the following packages:
```
Facebook
Facebook.client
Win2D.win81
ZXing.Net
```

##step three

- Clone CN1WindowsPort
```
git clone https://github.com/Pmovil/CN1WindowsPort.git
```
- Drag the src folder into your project root

##step four 

- From the windows build with sources included, drag your app's specific files/folders into src. DO NOT drag any other files (pisces, etc)

##step five

- Drag the res folder into your project root, select all files inside and change Build Action to Content and Copy to Output Directory to Copy always

##step six

- In the CN1WindowsPort there are templates for App.xaml* and MainPage.xaml* that you should fill with the your app's data (take a look at the windows build source files to understand how these should be filled) 

##step seven

- From the windows build with sources included drag Main.cs into your project.

##step eight

- Fix the needed usings

##step nine

- Change the App.xaml Build Action to ApplicationDefinition

##step ten

- Select either x86 or ARM and go to BUILD > Rebuild Solution

#Optional steps

##Extra permissions:

- Under Package.appxmanifest > Capabilities you may add the needed permissions to your app, you should add at least Internet and Removable Storage.

##Facebook support:

- In order to use the native Facebook support you must add a FacebookConfig.xml with your id like this:

```
<?xml version="1.0" encoding="utf-8" ?>
<Extensions>
  <Facebook AppId="0000000000000000" 
            RedirectUrl="http://my.redirect.com/"
            Permissions="public_profile,email,user_friends"/>
</Extensions>
```
