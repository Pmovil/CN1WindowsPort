# CN1WindowsPort
Windows RT port to Codename One

This port is a work in progress targeting the newest windows devices. You will need Visual Studio to compile and test it.

#Installation

- Send a windows 8 build to the codename one cloud with sources included (pro subscription needed)
- Download the source and replace the codename one files by the ones in this port
- replace the auto-generated MainPage using our template
- Create a Windows Universal apps project, include these files
- add the required dependencies to the project (Win2D, Zxing, Facebook)

#Facebook support

In order to use the Facebook support you must add a FacebookConfig.xml with your id like this:

```
<?xml version="1.0" encoding="utf-8" ?>
<Extensions>
  <Facebook AppId="0000000000000000" />
</Extensions>
```
and then, in your Package.appxmanifest under Declarations you must add a new Protocol with name fb0000000000000000
