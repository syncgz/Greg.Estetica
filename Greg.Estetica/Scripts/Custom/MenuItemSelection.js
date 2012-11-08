
var menuSelector = 'menu_item';

var selectedImageIndex = 1;

$(document).ready(function () {
    RegisterMenuEvents();
});

function RegisterMenuEvents() {

    $('#menu>ul>li>a').click(function () {
        SelectItem($(this));
    });
}

function SelectItem(item) {
    $('#menu>ul>li>a').removeData(menuSelector);

    $(item).data(menuSelector, '1');

    UpdateMenu();

}

function UpdateMenu() {
    $('#menu>ul>li>a').removeClass().each(function () {
        if ($(this).data(menuSelector) == '1') {
            $(this).addClass('test');
        }
    });
}
