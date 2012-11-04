$(document).ready(function ()
{
    
    
    $('#menu>ul>li>a').click(function (event)
    {
        
        
        event.preventDefault();
        
        var url = $(this).attr('href');
        
        $('#ajaxBlock').load(url);
        
        GalleryMenu();
        
    });
    
    
})

function GalleryMenu(parameters)
{
    var abc = $(".galleryItem").length;
    
    alert("Gallery menu" + abc);

    $(".galleryItem").click(function (e)
    {
        alert("....");
        ShowPhotoDialog();
        
    });
}

function ShowPhotoDialog() {
    $("#dialog-modal").dialog({
        height: 140,
        modal: true
    });
};

