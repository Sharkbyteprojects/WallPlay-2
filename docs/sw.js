/**
 * Welcome to your Workbox-powered service worker!
 *
 * You'll need to register this file in your web app and you should
 * disable HTTP caching for this file too.
 * See https://goo.gl/nhQhGp
 *
 * The rest of the code is auto-generated. Please don't update this file
 * directly; instead, make changes to your Workbox build configuration
 * and re-run your build process.
 * See https://goo.gl/2aRDsh
 */

importScripts("https://storage.googleapis.com/workbox-cdn/releases/4.2.0/workbox-sw.js");

self.addEventListener('message', (event) => {
  if (event.data && event.data.type === 'SKIP_WAITING') {
    self.skipWaiting();
  }
});

/**
 * The workboxSW.precacheAndRoute() method efficiently caches and responds to
 * requests for URLs in the manifest.
 * See https://goo.gl/S9QRab
 */
self.__precacheManifest = [
  {
    "url": "Build/UnityLoader.js",
    "revision": "3544178c924aac8c5129f2d974d60dd7"
  },
  {
    "url": "Build/wgl.data.unityweb",
    "revision": "fdef6524e7a80ffb0950f8045a746488"
  },
  {
    "url": "Build/wgl.jpg",
    "revision": "66f963a0413ab79e521d159cc7120d23"
  },
  {
    "url": "Build/wgl.json",
    "revision": "d6969fde618b16258a141ae21be27187"
  },
  {
    "url": "Build/wgl.wasm.code.unityweb",
    "revision": "4ca5a37c8947dbfc14f93a34463c9b5b"
  },
  {
    "url": "Build/wgl.wasm.framework.unityweb",
    "revision": "897ca979889ae78ee770ebd42e546ba2"
  },
  {
    "url": "index.html",
    "revision": "8419d68a52752ffc3515f6d98e67fc9b"
  },
  {
    "url": "workbox-config.js",
    "revision": "c06cc5d555b470a65cb0fee610994c9c"
  }
].concat(self.__precacheManifest || []);
workbox.precaching.precacheAndRoute(self.__precacheManifest, {});
