WAMongoLabTutorial
==================

This code accompanies the Tutorial "Tutorial: Using MongoDB, Windows Communication Foundation, OData, and PowerBI to build a Business Intelligence solution on Windows Azure" at http://msopentech.com/blog/2014/02/19/tutorial-using-mongodb-windows-communication-foundation-odata-powerbi-build-business-intelligence-solution-windows-azure/


==================

For this tutorial we’re combining three open themes – Open Government, Open Data, and Open source. First, for Open Government, we’re using open domain data provided by the US Federal Aviation Administration. Next, we’re using an open source Database, MongoDB, to store data and lastly, we’re using the Open Data protocol (OData) to connect to and visualize the data.

The sample code here is for setting up the WCF Data Service.  Note that the WCF Data Service needs to run on Azure, not locally, and has to be connected to the MongoDb database via an OData driver.  The easiest way to find an Odata data driver for MongoDB is to open the NuGet package manager and search for a MongoDB OData driver. I used the driver here: https://nuget.org/packages/MongOData/0.10.4.1

More details on the driver can be found here: http://bloggingabout.net/blogs/vagif/archive/2012/05/19/expose-mongodb-data-as-odata-feed-using-mongodata-provider.aspx

And the source code can be found here: https://github.com/object/MongOData

You need to change two things in this code to make this work in your installation, then publish the code as a WCF Data Service:

Under App_Code, in OdataWcfDataService.cs, change the MongoDb connection string to point to your MongoDB Instance::

protected override MongoServer CreateMongoServer()
    {
        return MongoServer.Create("<your MongoDBconnection String Goes Here - Example: mongodb://URL:27017>");
    }
	
In the OdataWcfDataService.svc file, name the service:

<%@ ServiceHost Language="C#" Factory="System.Data.Services.DataServiceHostFactory" Service="<your service Name goes here>" %>

