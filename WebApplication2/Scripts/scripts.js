function updateTimer(time) {
    $("#check")[0].disabled = true;
    var t = time;
    var timer = setInterval(function () {
        if (t < 0) {
            $("#timer")[0].innerHTML = "0s";
            clearInterval(timer);
            check();
        } else {
            t = t.toFixed(2);
            $("#timer")[0].innerHTML = t + "s";
            t = t - 0.01;
        }
    }, 10)
}

function correct() {
    $("#correct")[0].style.color = '#2C4';

    $("#correct")[0].innerHTML = "ACCESS GRANTED";

}