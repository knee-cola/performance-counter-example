# What's this?

This i sa simple ASP.Net application, which demonstates the use of Windows performance counters.

It's a good starting point for using this feature in your applicaiton...


# Implementation details

The first file which was written is `Diagnostics/Counters/MyCounterSource.cs`. It contains counter definitions.

Next `Global.asax` was created, which creates counter instances as the application starts. They are assigned to static public property so that they can be accessed from each part of the application.

In the last step we created `default.asp`, in which counters are used - they are incremented with each processed request / page load.

# I wan to find out more

This example was based on the following article: [To Help Create Provider Performance Counters v 2.0 in NET. Framework](https://www.codeproject.com/Tips/897687/To-Help-Create-Provider-Performance-Counters-v)