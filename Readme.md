# Product Service


To test locally need to reserve URL for your console application to startup.
Command to reserve your URL is:

```
netsh http add urlacl url=http://+:9090/soap/ user=DESKTOP-MHNRP1T\Admin
```

The url pattern here needs to match with what is in your App.config's host/baseAddresses section in your console application. In our case, that is the Host console app's App.config file.

