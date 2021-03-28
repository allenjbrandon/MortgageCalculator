
function getMonthlyPayments() {
    //highMonthlyCost
    var newGross = document.getElementById("salary").value / 12;
    var highMonthly = Math.round(newGross * .45 - document.getElementById("debt").value);
    document.getElementById("highMonthly").innerHTML = "High Monthly Cost: " + highMonthly;

    //lowMonthlyCost
    var newGross = document.getElementById("salary").value / 12;
    var lowMonthly = Math.round(newGross * .25 - document.getElementById("debt").value);
    document.getElementById("lowMonthly").innerHTML = "Low Monthly Cost: " + lowMonthly;

    //middleMonthlyCost
    var newGross = document.getElementById("salary").value / 12;
    var middleMonthly = Math.round(newGross * .35 - document.getElementById("debt").value);
    document.getElementById("middleMonthly").innerHTML = "Middle Monthly Cost: " + middleMonthly;

    //downpayment to mortgage
    var mortgageFromDownPayment = document.getElementById("dpayment").value * 5;
    document.getElementById("mortgageWithDownpayment").innerHTML = "Your downpayment would be 20% of a $" + mortgageFromDownPayment + " house.";
}

function isNumber() {
    var x, text;

    x = document.getElementById("dpayment").value;

    if (isNaN(x)) {
        text = "Please Type a Number";
    } else {
        text = " ";
    }
    document.getElementById("downpaymentValidation").innerHTML = text;
}




var modal = document.getElementById("monthlyCostModal");

var btn = document.getElementById("myBtn");

var span = document.getElementsByClassName("close")[0];

btn.onclick = function () {

    var x, text;

    x = document.getElementById("dpayment").value;

    if (isNaN(x)) {
        text = "Please Type a Number";
        document.getElementById("downpaymentValidation").innerHTML = text;
    } else if (x == "") {
        text = "Please type a number";
        document.getElementById("downpaymentValidation").innerHTML = text;
    } else {
        getMonthlyPayments();
        modal.style.display = "block";
    }
}

span.onclick = function () {
    modal.style.display = "none";
}

window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}