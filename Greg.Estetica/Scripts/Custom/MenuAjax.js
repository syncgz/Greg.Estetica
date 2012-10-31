$(document).ready(function ()
{
    $('#menu>ul>li>a').click(function (event)
    {
        event.preventDefault();
        
        var url = $(this).attr('href');
        
        $('#ajaxBlock').load(url);

    });
})

