

var _ = require("lodash"),
    gulp = require("gulp"),
    rimraf = require("rimraf"),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify");

var webroot = "./wwwroot/";
var js = [
    './node_modules/core-js/client/shim.js',
    './node_modules/zone.js/dist/zone.js',
    './node_modules/reflect-metadata/Reflect.js',
    './node_modules/systemjs/dist/system.src.js',
    'systemjs.config.js'
];



gulp.task('copy-js', function () {
    _.forEach(js, function (file, _) {
        gulp.src(file).pipe(gulp.dest('./wwwroot/js'))
    });
});

gulp.task('copy-min-js', function () {
    _.forEach(js, function (file, _) {
        gulp.src(file).pipe(uglify()).pipe(rename({ extname: '.min.js' })).pipe(gulp.dest('./wwwroot/js'))
    });
});

var paths = {
    npm:"./node_modules/",
    js: webroot + "js/**/*.js",
    minJs: webroot + "js/**/*.min.js",
    css: webroot + "css/**/*.css",
    minCss: webroot + "css/**/*.min.css",
    concatJsDest: webroot + "js/site.min.js",
    concatCssDest: webroot + "css/site.min.css",
    cssVendor: webroot + "/lib/css",
    jsVendor: webroot + "/lib/js",
    imgVendor: webroot + "/lib/img",
    fontsVendor:webroot+"/lib/fonts"
};

gulp.task("clean:js", function (cb) {
    rimraf(paths.concatJsDest, cb);
});

gulp.task("clean:css", function (cb) {
    rimraf(paths.concatCssDest, cb);
});

gulp.task("clean", ["clean:js", "clean:css"]);

gulp.task("setup-vendor", function (done) {
    gulp.src(['systemjs.config.js',
        'bower_components/alertify.js/lib/alertify.min.js',
        'node_modules/fancybox/dist/js/jquery.fancybox.pack.js',
        'bower_components/bootstrap/dist/js/bootstrap*.js',
        'bower_components/jquery/dist/jquery.*js'

    ]).pipe(gulp.dest(paths.js));
});

gulp.task("min:js", function () {
     gulp.src([paths.js, "!" + paths.minJs], { base: "." })
        .pipe(concat(paths.concatJsDest))
        .pipe(uglify())
        .pipe(gulp.dest("."));
});

gulp.task("min:css", function () {
     gulp.src([paths.css, "!" + paths.minCss])
        .pipe(concat(paths.concatCssDest))
        .pipe(cssmin())
        .pipe(gulp.dest("."));
});

gulp.task("min", ["min:js", "min:css"]);
