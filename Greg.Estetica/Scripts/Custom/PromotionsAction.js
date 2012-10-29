var windowSize = 3;

var index1 = 0;
var index2 = 1;
var index3 = 2;

var allElements;

function DisplayPromotions() 
{
    allElements = $(".style1 > li");

    var visibleElements = $(".style1 > li:visible");



    if (allElements.length > windowSize) 
    {
        allElements.hide();  

        if (visibleElements != 0)  
        {
            //regular sliding window movement
            index1 = CalculateIndex(index1);
            index2 = CalculateIndex(index2);
            index3 = CalculateIndex(index3);
        }

        console.log("Index1: " + index1);
        console.log("Index2: " + index2);
        console.log("Index3: " + index3);

        ShowItem(allElements.get(index1));
        ShowItem(allElements.get(index2));
        ShowItem(allElements.get(index3));
    }
}

function HideItem(element) 
{
    element.style.display = "none";
}

function ShowItem(element) 
{
    element.style.display = "inline";
}

function CalculateIndex(index) 
{
    index++;

    if (index == allElements.length) 
    {
        return 0;
    }

    return index;
}

function Initialization() 
{
    $(".style1 > li").hide();
}

//    var allElements = $(".style1 > li");

//    console.log("All elements count:" + allElements.length);

//    if (allElements.length > 3) 
//    {
//        var hideCount = allElements.length - 3;

//        console.log("How many to hide:" + hideCount);

//        var visibleItems = $(".style1 > li:visible");

//        console.log("Visible elements count:" + visibleItems.length);

//        allElements.show();

//        var loopCond = 0;

//        while (loopCond < hideCount) 
//        {
//            visibleItems.get(loopCond).style.display="none";
//            loopCond++;
//        }
//    }
//}