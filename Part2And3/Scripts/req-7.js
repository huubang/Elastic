$.fn.openLinksNewWindow = function (options) {
    var settings = $.extend({
        // These are the defaults.

        width: 200,
        height: 200

    }, options);


    this.find('a').data('window-width', settings.width);
    this.find('a').data('window-height', settings.height);

    this.find('a').click(function (event) {
        event.preventDefault();

        var specs = '';
        if ($(this).data('window-width') != null) {
            specs += 'width=' + $(this).data('window-width');
        }

        if ($(this).data('window-height') != null) {
            specs += ',height=' + $(this).data('window-height');
        }
        window.open(this.href, $(this).data('window-group'), specs);
    })

    return this;
};