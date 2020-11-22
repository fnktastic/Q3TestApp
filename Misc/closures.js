// assume jQuery is loaded

function registerHandlers() {
  var as = $('a');
  for (var i = 0; i < as.length; i++) {
    $(as[i]).on('click', function() {
      alert(i);
      return false;
    });
  }
}