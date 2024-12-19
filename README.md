# Create-a-Chat-Application-using-the-MAUI-ListView

This sample demonstrates how to create a chat application using the MAUI ListView control within a .NET MAUI application.

## Sample

```xaml
<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="IncomingMessage">
            <Grid Padding="10,5">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="Auto"/>
                    <ColumnDefinition Width="*"/>
                </Grid.ColumnDefinitions>

                <Image WidthRequest="40" HeightRequest="40" HorizontalOptions="Start"
                       VerticalOptions="Start" Margin="5"
                       Source="{Binding ProfilePicture}">
                </Image>

                <StackLayout Grid.Column="1" Orientation="Vertical" Padding="5,0">
                    <Label Text="{Binding Name}" TextColor="Gray" FontSize="12"
                           FontAttributes="Bold" HorizontalOptions="Start"/>
                    <Label Text="{Binding Text}" TextColor="Black" BackgroundColor="LightGray"
                           Padding="10" MaximumWidthRequest="250"
                           HorizontalOptions="StartAndExpand" VerticalOptions="Center"/>
                    <Label Text="{Binding Timestamp, StringFormat='{0:HH:mm}'}"
                           TextColor="Gray" FontSize="10" HorizontalOptions="Start"/>
                </StackLayout>
            </Grid>
        </DataTemplate>

        <DataTemplate x:Key="OutgoingMessage">
            <Grid Padding="10,5">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="Auto" />
                    <ColumnDefinition Width="Auto"/>
                </Grid.ColumnDefinitions>

                <StackLayout Grid.Column="1" Orientation="Vertical" Padding="5,0" 
                             VerticalOptions="CenterAndExpand">
                    <Label Text="{Binding Name}" TextColor="Gray" FontSize="12"
                           FontAttributes="Bold" HorizontalOptions="End" />
                    <Label Text="{Binding Text}" TextColor="White" 
                           BackgroundColor="DodgerBlue" Padding="10" 
                           HorizontalOptions="EndAndExpand" VerticalOptions="Center"
                           MaximumWidthRequest="250" />
                    <Label Text="{Binding Timestamp, StringFormat='{0:HH:mm}'}"
                           TextColor="Gray" FontSize="10" HorizontalOptions="End"/>
                </StackLayout>

                <Image Grid.Column="2" WidthRequest="40" HeightRequest="40" Margin="5"
                       HorizontalOptions="End" VerticalOptions="Start"
                       Source="{Binding ProfilePicture}">
                </Image>
            </Grid>
        </DataTemplate>

        <local:MyDataTemplateSelector x:Key="dataTemplateSelector"
                                      IncomingDataTemplate="{StaticResource IncomingMessage}"
                                      OutgoingDataTemplate="{StaticResource OutgoingMessage}"/>
    </ResourceDictionary>
</ContentPage.Resources>

<listView:SfListView ItemsSource="{Binding Messages}"
                     ItemTemplate="{StaticResource dataTemplateSelector}"
                     AutoFitMode="Height">
</listView:SfListView>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples.
