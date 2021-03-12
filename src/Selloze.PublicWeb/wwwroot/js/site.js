const formatter = new Intl.NumberFormat('en-US', {
    style: 'currency',
    currency: 'USD',
    minimumFractionDigits: 2
});

const tradeWs = new WebSocket('wss://ws.coincap.io/trades/binance');

tradeWs.onerror = function (msg) {
    console.log(msg);
}

tradeWs.onmessage = function (msg) {
    //console.clear();
    console.log(msg.data);

    updateData(msg.data);
};

$(document).ready(function () {
    $('#coins').DataTable({
        "order": [],
        "pageLength": 25
    });

    $("#loader").hide(50);
    $("#coins").show(0);

});

window.updateData = function (data) {

    let jsonObject = JSON.parse(data);

    if (jsonObject.quote !== undefined) {

        let coin = 'COIN_' + jsonObject.base;
        let coin_data = jsonObject;

        let _coinTable = $('#coins');
        let row = _coinTable.find("tr#" + coin);
        let price = _coinTable.find("tr#" + coin + " .price");
        let change = _coinTable.find("tr#" + coin + " .change");
        let volume = _coinTable.find("tr#" + coin + " .volume");
        let capital = _coinTable.find("tr#" + coin + " .market_capital");
        let supply = _coinTable.find("tr#" + coin + " .supply");
        let _price = formatter.format(coin_data.price);
        let previous_price = $(price).data('usd');
        let _class = coin_data.direction === 'buy' ? 'increment' : 'decrement';
        if (coin_data.direction === 'buy') {
            $(price).html(_price).removeClass().addClass(_class + ' price').data("usd", _price);
        } else {
            $(price).html(_price).removeClass().addClass(_class + ' price').data("usd", _price);
        }
        $(volume).html(formatter.format(coin_data.volume));
        
        if (_class === 'buy') {
            coin_data.priceUsd = $(capital).html().replace('$', '') + coin_data.priceUsd;
            $(capital).html(formatter.format(coin_data.priceUsd));
        }
        else {
            coin_data.priceUsd = $(capital).html().replace('$', '') - coin_data.priceUsd;
            $(capital).html(formatter.format(coin_data.priceUsd));
        }
        
        $(supply).html(new Intl.NumberFormat('en-US').format(coin_data.priceUsd));

        if (_price !== previous_price) {
            _class = previous_price < _price ? 'increment' : 'decrement';
            $(row).addClass(_class);
            setTimeout(function () {
                $(row).removeClass('increment decrement');
            }, 500);
        }
    }
};