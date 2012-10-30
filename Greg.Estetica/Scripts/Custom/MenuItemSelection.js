
var menuSelector = 'menu_item';

function SelectItem(item) 
{
    $('menu>ul>li>a').removeData(menuSelector);

    $(item).data(menuSelector, '1');

    UpdateMenu();

}

function UpdateMenu() 
{
    $('menu>ul>li>a').removeClass().each(function () 
    {
        if ($(this).data(menuSelector) == '1') 
        {
            $(this).addClass('test');
        }
    });
}

function RegisterMenuEvents() 
{
    $('menu>ul>li>a').click(function () 
    {
        SelectItem($(this));
    });
}