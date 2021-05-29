# Product Service


To test locally need to reserve URL for your console application to startup.
Command to reserve your URL is:

```
netsh http add urlacl url=http://+:9090/soap/ user=<MachineName>\<LoggedInUser>
```

The url pattern here needs to match with what is in your App.config's host/baseAddresses section in your console application. In our case, that is the Host console app's App.config file.

For more information see this link: https://docs.microsoft.com/en-us/dotnet/framework/wcf/feature-details/configuring-http-and-https?redirectedfrom=MSDN


Dependency Injection with [Autofac](https://autofac.readthedocs.io/en/latest/).
Helpful articles to properly configure Autofac with self hosting console app:

https://www.codeproject.com/Tips/5163365/Dependency-injection-in-WCF-Service-Library-projec

https://alexmg.dev/posts/self-hosting-wcf-services-with-the-autofac-wcf-integration

https://alexmg.dev/posts/making-self-hosting-with-autofac-wcf-integration-easier


