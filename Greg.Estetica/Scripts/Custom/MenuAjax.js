

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

