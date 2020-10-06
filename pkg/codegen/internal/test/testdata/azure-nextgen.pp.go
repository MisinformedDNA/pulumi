package main

import (
	portal "github.com/pulumi/pulumi-azure-nextgen/sdk/go/azure/portal/v20200901preview"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := portal.NewDashboard(ctx, "dashboard", &portal.DashboardArgs{
			DashboardName: pulumi.String("testDashboard"),
			Lenses: pulumi.Array{
				pulumi.Map{
					"order": pulumi.Float64(1),
					"parts": pulumi.Float64MapMapArray{
						pulumi.Float64MapMap{
							"position": pulumi.Float64Map{
								"colSpan": pulumi.Float64(3),
								"rowSpan": pulumi.Float64(4),
								"x":       pulumi.Float64(1),
								"y":       pulumi.Float64(2),
							},
						},
						pulumi.Float64MapMap{
							"position": pulumi.Float64Map{
								"colSpan": pulumi.Float64(6),
								"rowSpan": pulumi.Float64(6),
								"x":       pulumi.Float64(5),
								"y":       pulumi.Float64(5),
							},
						},
					},
				},
				pulumi.Map{
					"order": pulumi.Float64(2),
					"parts": []interface{}{},
				},
			},
			Location: pulumi.String("eastus"),
			Metadata: pulumi.Float64MapMap{
				"metadata": pulumi.Float64Map{
					"ColSpan": pulumi.Float64(2),
					"RowSpan": pulumi.Float64(1),
					"X":       pulumi.Float64(4),
					"Y":       pulumi.Float64(3),
				},
			},
			ResourceGroupName: pulumi.String("testRG"),
			Tags: pulumi.StringMap{
				"aKey":       pulumi.String("aValue"),
				"anotherKey": pulumi.String("anotherValue"),
			},
		})
		if err != nil {
			return err
		}
		return nil
	})
}
