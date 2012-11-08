

$(document).ready(function ()
{
    
    
    $('#menu>ul>li>a').click(function (event)
    {
        event.preventDefault();
        
        var menuItemElement = event.target.id;

        var url = $(this).attr('href');
        
        $('#ajaxBlock').load(url, function ()
        {
            switch (menuItemElement)
            {
                case MENU_GALLERY:
                    GalleryMenu();
                    break;
                case MENU_PRICE_LIST:
                    AccordionMenu();
                    break;
            }
        });
        
        
        
    });
    
    
})

function GalleryMenu(parameters)
{
    $("img.galleryItem").bind('click', function (e)
    {
        var index = $("img.galleryItem").index(this);

        ShowPhotoDialog(index);
    });
}

function ShowPhotoDialog(index) {

    $("#dialog-modal").dialog({
        height: 600,
        width: 1000,
        dialogClass: "foo",
        modal: true
    });
    
    $(".foo .ui-dialog-titlebar").css("display", "none");
    $(".foo .ui-dialog-title").css("font-size", "5px");
    $(".foo .ui-widget-header").css("display", "none");
    $(".foo .ui-widget-content").css("background-color", "black");
    $(".foo .ui-widget-content").css("font-size", "12px");
    $(".ui-corner-all").css("background-color", "black");
    $(".ui-resizable-n").css("background-image", "none");
    
    //$("#dialog-modal").position({
    //    my: "center",
    //    at: "center",
    //    of: "window"
    //});
    
    var gallery = Galleria.get(0);

    try 
    {
        gallery.show(index);
    } 
    catch(e) 
    {
        Galleria.configure({
            show: index
        });
    } 

    
};

