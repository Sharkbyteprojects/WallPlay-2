module.exports = {
  "globDirectory": ".",
  "globPatterns": [
    "**/*.{js,unityweb,jpg,json,html}"
  ],
  "swDest": "sw.js",
  "maximumFileSizeToCacheInBytes": 9000000000
};//BUILD:
// workbox generateSW workbox-config.js