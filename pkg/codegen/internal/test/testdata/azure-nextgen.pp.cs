using Pulumi;
using AzureNextGen = Pulumi.AzureNextGen;

class MyStack : Stack
{
    public MyStack()
    {
        var dashboard = new AzureNextGen.Portal.Dashboard("dashboard", new AzureNextGen.Portal.DashboardArgs
        {
            DashboardName = "testDashboard",
            Lenses =
            {
                new AzureNextGen.Portal.Inputs.DashboardLensArgs
                {
                    Order = 1,
                    Parts =
                    {
                        new AzureNextGen.Portal.Inputs.DashboardPartsArgs
                        {
                            Position = new AzureNextGen.Portal.Inputs.DashboardPartsPositionArgs
                            {
                                ColSpan = 3,
                                RowSpan = 4,
                                X = 1,
                                Y = 2,
                            },
                        },
                        new AzureNextGen.Portal.Inputs.DashboardPartsArgs
                        {
                            Position = new AzureNextGen.Portal.Inputs.DashboardPartsPositionArgs
                            {
                                ColSpan = 6,
                                RowSpan = 6,
                                X = 5,
                                Y = 5,
                            },
                        },
                    },
                },
                new AzureNextGen.Portal.Inputs.DashboardLensArgs
                {
                    Order = 2,
                    Parts = {},
                },
            },
            Location = "eastus",
            Metadata =
            {
                { "metadata",
                {
                    { "ColSpan", 2 },
                    { "RowSpan", 1 },
                    { "X", 4 },
                    { "Y", 3 },
                } },
            },
            ResourceGroupName = "testRG",
            Tags =
            {
                { "aKey", "aValue" },
                { "anotherKey", "anotherValue" },
            },
        });
    }

}
