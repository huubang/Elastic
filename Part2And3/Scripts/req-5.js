String.prototype.startsWith = function (prefix) {
    return this.substring(0, prefix.length) == prefix;
};

String.prototype.endsWith = function (suffix) {
    return this.indexOf(suffix, this.length - suffix.length) !== -1;
};

String.prototype.stripHtml = function () {    
    return this.replace(/<\S[^><]*>/g, "");
};

