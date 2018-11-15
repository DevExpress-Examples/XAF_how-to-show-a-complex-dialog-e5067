<!-- default file list -->
*Files to look at*:

* [BusinessObjects.cs](./CS/ComplexDialogSample.Module/BusinessObjects/BusinessObjects.cs) (VB: [BusinessObjects.vb](./VB/ComplexDialogSample.Module/BusinessObjects/BusinessObjects.vb))
* [MyController.cs](./CS/ComplexDialogSample.Module/Controllers/MyController.cs) (VB: [MyController.vb](./VB/ComplexDialogSample.Module/Controllers/MyController.vb))
<!-- default file list end -->
# How to show a complex dialog


<p><strong>Task:</strong> We need to ask the user for a number of values by presenting a complex dialog with a number of entry fields nicely arranged.</p>
<p><strong>Solution:</strong> An arbitrary dialog can be shown using standard XAF concepts. Any XAF form is a window that shows a certain view. To show a dialog, we create a non-persistent class with properties representing entry fields and show a <a href="https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppDetailViewtopic.aspx">DetailView</a> of its instance via the <a href="https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112723">PopupWindowShowAction</a>. The class we created is included in the application model and has its default generated detail view, which we can customize to achieve the desired layout. Besides querying simple values, we can add a collection-type property to the dialog class to allow selecting items from the list. This selection can be read in the action's Execute event by accessing <strong>ListPropertyEditor</strong> representing the nested list view. The popup window displayed via the action contains the usual OK and Cancel action buttons provided by the <a href="https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppSystemModuleDialogControllertopic.aspx">DialogController</a>. If necessary, you can provide additional action buttons by creating a controller for the dialog class with the Category set to <strong>PopupActions</strong>.</p>
<p>Note, to show collections in an editable detail view on the Web, use <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3230"><u>this solution</u></a><u>.</u><u></u></p>
<p><u>See also:<br><a href="https://documentation.devexpress.com/eXpressAppFramework/CustomDocument116516.aspx">Non-Persistent Objects</a><br></u></p>

<br/>


