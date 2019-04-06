window.skorStorage = {
    get: function (key) {
        let item = window.localStorage.getItem(key);
        if (item) {
            return JSON.parse(item);
        } else {
            return null;
        }
    },
    set: function (key, value) {
        window.localStorage.setItem(key, JSON.stringify(value));
    },
    remove: function (key) {
        window.localStorage.removeItem(key);
    },
    clear: function () {
        window.localStorage.clear();
    },
    length: function () {
        return window.localStorage.length;
    }
};