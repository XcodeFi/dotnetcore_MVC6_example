

var _ = require("lodash"),
    gulp = require("gulp"),
    rimraf = require("rimraf"),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify"),
    ts = require("gulp-typescript");

var webroot = "./wwwroot/";

var js = [
    './node_modules/core-js/client/shim.js',
    './node_modules/zone.js/dist/zone.js',
    './node_modules/reflect-metadata/Reflect.js',
    './node_modules/systemjs/dist/system.src.js',
    'systemjs.config.js'
];



//gulp.task('copy-js', function () {
//    _.forEach(js, function (file, _) {
//        gulp.src(file).pipe(gulp.dest('./wwwroot/js'))
//    });
//});

//gulp.task('copy-min-js', function () {
//    _.forEach(js, function (file, _) {
//        gulp.src(file).pipe(uglify()).pipe(rename({ extname: '.min.js' })).pipe(gulp.dest('./wwwroot/js'))
//    });
//});

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
    fontsVendor: webroot + "/lib/fonts",

    tsOutput: webroot + '/lib/spa/'
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
        'bower_components/bootstrap/dist/js/bootstrap.*js',
        'bower_components/jquery/dist/jquery.*js',
        'bower_components/jquery-validation/dist/jquery.validate.*js',
        'bower_components/jquery-validation-unobtrusive/jquery.validate.unobtrusive.*js'
    ]).pipe(gulp.dest(paths.jsVendor));

    gulp.src(['bower_components/bootstrap/dist/css/bootstrap.*css',
      'bower_components/components-font-awesome/css/font-awesome.*css',
      'bower_components/alertify.js/themes/alertify.core.*css',
      'bower_components/alertify.js/themes/alertify.bootstrap.*css',
      'bower_components/alertify.js/themes/alertify.default.*css'
    ]).pipe(gulp.dest(paths.cssVendor));

    gulp.src(['node_modules/bootstrap/fonts/glyphicons-halflings-regular.eot',
      'bower_components/bootstrap/fonts/glyphicons-halflings-regular.svg',
      'bower_components/bootstrap/fonts/glyphicons-halflings-regular.ttf',
      'bower_components/bootstrap/fonts/glyphicons-halflings-regular.woff',
      'bower_components/bootstrap/fonts/glyphicons-halflings-regular.woff2',
      'bower_components/components-font-awesome/fonts/FontAwesome.otf',
      'bower_components/components-font-awesome/fonts/fontawesome-webfont.eot',
      'bower_components/components-font-awesome/fonts/fontawesome-webfont.svg',
      'bower_components/components-font-awesome/fonts/fontawesome-webfont.ttf',
      'bower_components/components-font-awesome/fonts/fontawesome-webfont.woff',
      'bower_components/components-font-awesome/fonts/fontawesome-webfont.woff2'
    ]).pipe(gulp.dest(paths.fontsVendor));

});

//var tsProject = ts.createProject('./wwwroot/tsconfig.json');

//gulp.task('compile-typescript', function (done) {
//    var tsResult = gulp.src([
//       "wwwroot/app/**/*.ts"
//    ])
//     .pipe(ts(""), undefined, ts.reporter.fullReporter());
//    return tsResult.js.pipe(gulp.dest(paths.tsOutput));
//});

//gulp.task('watch.ts', ['compile-typescript'], function () {
//    return gulp.watch('./wwwroot/app/**/*.ts', ['compile-typescript']);
//});

//gulp.task('watch', ['watch.ts']);

//gulp.task('clean-lib', function () {
//    return del([lib]);
//});

//gulp.task('build-spa', ['setup-vendors', 'compile-typescript']);


//gulp.task("min:js", function () {
//     gulp.src([paths.js, "!" + paths.minJs], { base: "." })
//        .pipe(concat(paths.concatJsDest))
//        .pipe(uglify())
//        .pipe(gulp.dest("."));
//});

//gulp.task("min:css", function () {
//     gulp.src([paths.css, "!" + paths.minCss])
//        .pipe(concat(paths.concatCssDest))
//        .pipe(cssmin())
//        .pipe(gulp.dest("."));
//});

//gulp.task("min", ["min:js", "min:css"]);
