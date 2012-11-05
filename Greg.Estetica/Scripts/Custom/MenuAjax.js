$(document).ready(function ()
{
    
    
    $('#menu>ul>li>a').click(function (event)
    {
        event.preventDefault();
        
        var url = $(this).attr('href');
        
        $('#ajaxBlock').load(url, function ()
        {
            GalleryMenu();
        });
        
        
        
    });
    
    
})

function GalleryMenu(parameters)
{
    $("img.galleryItem").bind('click', function (e)
    {
        ShowPhotoDialog();
    });
}

function ShowPhotoDialog() {
    
    

    $("#dialog-modal").dialog({
        height: 'auto',
        width:'auto',
        dialogClass: "foo"
    });
    
    $(".foo .ui-dialog-titlebar").css("display", "none");
    $(".foo .ui-dialog-title").css("font-size", "5px");
    $(".foo .ui-widget-header").css("display", "none");
    $(".foo .ui-widget-content").css("background-color", "black");
    $(".foo .ui-widget-content").css("font-size", "12px");
    $(".ui-corner-all").css("background-color", "black");
    $(".ui-resizable-n").css("background-image", "none");
    
    $("#dialog-modal").position({
        my: "center",
        at: "center",
        of: "body"
    });
};

