#pragma checksum "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1a7de3ff2fe4fc54abbcbed1964cd392ac96b01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mission_Mission6), @"mvc.1.0.view", @"/Views/Mission/Mission6.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\_ViewImports.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\_ViewImports.cshtml"
using FYPFinalCode.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1a7de3ff2fe4fc54abbcbed1964cd392ac96b01", @"/Views/Mission/Mission6.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbbbd471861c5ad4dc73065ec50981ffcc6d1823", @"/Views/_ViewImports.cshtml")]
    public class Views_Mission_Mission6 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UploadPhoto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Mission/Mission6Post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    // Represents one pixel in a SimpleImage, supports rgb get/set.
    SimplePixel = function (simple_image, x, y) {
        __SimpleImageUtilities.funCheck('SimplePixel', 3, arguments.length);
        this.container = simple_image;
        this.x = x;
        this.y = y;
    };

    SimplePixel.prototype = {
        constructor: SimplePixel,
        getX: function () {
            __SimpleImageUtilities.funCheck('getX', 0, arguments.length);
            return this.x;
        },
        getY: function () {
            __SimpleImageUtilities.funCheck('getY', 0, arguments.length);
            return this.y;
        },
        getAlpha: function () {
            __SimpleImageUtilities.funCheck('getAlpha', 0, arguments.length);
            return this.container.getAlpha(this.x, this.y);
        },
        setAlpha: function (val) {
            __SimpleImageUtilities.funCheck('setAlpha', 1, arguments.length);
            this.container.setAlpha(this.x, this.y, val);
        },");
            WriteLiteral(@"
        setAllFrom: function (pixel) {
            __SimpleImageUtilities.funCheck('setAllFrom', 1, arguments.length);
            this.setRed(pixel.getRed());
            this.setGreen(pixel.getGreen());
            this.setBlue(pixel.getBlue());
            this.setAlpha(pixel.getAlpha());
        },
        toString: function () {
            return 'r:' + this.getRed() + ' g:' + this.getGreen() + ' b:' + this.getBlue();
        },
        // Render pixel as string
        getString: function () {
            return this.toString();
        }
    };


    // Note there is an Image built in, so don't use that name.
    // A SimpleImage can be created with a url, size, or an existing htmlImage or canvas
    SimpleImage = function () {
        if (arguments.length < 0 || arguments.length > 2) {
            __SimpleImageUtilities.funCheck('SimpleImage', 1, arguments.length);
            return null;
        }
        // function map for to support ""overloaded constructor""
        var ");
            WriteLiteral(@"funMap = [
            function () {
                return __SimpleImageUtilities.EMPTY_IMAGE;
            },
            function (source) {
                if (source instanceof HTMLImageElement) {
                    return source;
                } else if (typeof source == 'string') {
                    return __SimpleImageUtilities.makeHTMLImageFromURL(source, this);
                } else if (source instanceof HTMLInputElement && source.type == 'file') {
                    return __SimpleImageUtilities.makeHTMLImageFromInput(source.files[0], this);
                } else if (source instanceof SimpleImage) {
                    return source.canvas;
                } else if (source instanceof HTMLCanvasElement) {
                    return source;
                } else {
                    __SimpleImageUtilities.throwError('Unrecognized value used to create a SimpleImage: ' + source);
                }
            },
            function (width, height) {
                if (wi");
            WriteLiteral(@"dth > 0 && height > 0) {
                    return __SimpleImageUtilities.makeHTMLImageFromSize(width, height);
                } else {
                    __SimpleImageUtilities.throwError('Unable to create a SimpleImage with a negative width or height [' + width + 'x' + height + ']');
                }
            }
        ];

        // call appropriate constructor
        var htmlImage = funMap[arguments.length].apply(this, arguments);
        // actual content is backed by an invisible canvas
        this.canvas = __SimpleImageUtilities.makeHTMLCanvas('SimpleImageCanvas');
        this.canvas.style.display = 'none';
        this.context = this.canvas.getContext('2d');
        // when image is loaded, it will fill this in
        this.imageData = null;
        // check to see if we can complete the constructor now instead of waiting
        if (htmlImage != null && (htmlImage instanceof HTMLCanvasElement || htmlImage.complete)) {
            this.__init(htmlImage);
        }
       ");
            WriteLiteral(@" this.ACCEPTED_FILES = 'image.*';
    }


    SimpleImage.prototype = {
        constructor: SimpleImage,
        complete: function () {
            return this.imageData != null;
        },
        getWidth: function () {
            __SimpleImageUtilities.funCheck('getWidth', 0, arguments.length);
            return this.width;
        },
        getHeight: function () {
            __SimpleImageUtilities.funCheck('getHeight', 0, arguments.length);
            return this.height;
        },

        getAlpha: function (x, y) {
            __SimpleImageUtilities.funCheck('getAlpha', 2, arguments.length);
            return this.imageData.data[this.__getIndex('getAlpha', x, y) + 3];
        },
        // Changes to the pixel write back to the image.
        getPixel: function (x, y) {
            __SimpleImageUtilities.funCheck('getPixel', 2, arguments.length);
            __SimpleImageUtilities.rangeCheck(x, 0, this.getWidth(), 'getPixel', 'x', 'wide');
            __SimpleImageUti");
            WriteLiteral(@"lities.rangeCheck(y, 0, this.getHeight(), 'getPixel', 'y', 'tall');
            return new SimplePixel(this, x, y);
        },


        setAlpha: function (x, y, value) {
            __SimpleImageUtilities.funCheck('setAlpha', 3, arguments.length);
            this.imageData.data[this.__getIndex('getAlpha', x, y) + 3] = __SimpleImageUtilities.clamp(value);
        },
        setPixel: function (x, y, pixel) {
            __SimpleImageUtilities.funCheck('setPixel', 3, arguments.length);
            __SimpleImageUtilities.rangeCheck(x, 0, this.getWidth(), 'setPixel', 'x', 'wide');
            __SimpleImageUtilities.rangeCheck(y, 0, this.getHeight(), 'setPixel', 'y', 'tall');
        },
        // Scales contents of SimpleIage to the given size
        setSize: function (width, height) {
            __SimpleImageUtilities.funCheck('setSize', 2, arguments.length);
            width = Math.floor(width);
            height = Math.floor(height);
            if (width > 0 && height > 0) {
       ");
            WriteLiteral(@"         // make sure we have the most current changes
                __SimpleImageUtilities.flush(this.context, this.imageData);
                this.imageData = __SimpleImageUtilities.changeSize(this.canvas, width, height);
                this.width = width;
                this.height = height;
                this.canvas.width = width;
                this.canvas.height = height;
            }
            else {
                __SimpleImageUtilities.throwError('You tried to set the size of a SimpleImage to a negative width or height [' + width + 'x' + height + ']');
            }
        },
        // Draws to the given canvas, setting its size to match SimpleImage's size
        drawTo: function (toCanvas) {
            if (this.imageData != null) {
                __SimpleImageUtilities.flush(this.context, this.imageData);
                toCanvas.width = this.getWidth();
                toCanvas.height = this.getHeight();
                toCanvas.getContext('2d').drawImage(this.can");
            WriteLiteral(@"vas, 0, 0, toCanvas.width, toCanvas.height);
            }
            else {
                var myself = this;
                setTimeout(function () {
                    myself.drawTo(toCanvas);
                }, 100);
            }
        },
        // Export an image as an linear array of pixels that can be iterated over
        toArray: function () {
            __SimpleImageUtilities.funCheck('toArray', 0, arguments.length);
            var array = new Array();
            // nip 2012-7
            // 1. simple-way (this is as good or faster in various browser tests)
            // var array = new Array(this.getWidth() * this.getHeight());
            // 2. change to cache-friendly y/x ordering
            // Non-firefox browsers may benefit
            for (var y = 0; y < this.getHeight(); y++) {
                for (var x = 0; x < this.getWidth(); x++) {
                    //array[i++] = new SimplePixel(this, x, y);  // 2.
                    array.push(new SimplePixel(this, ");
            WriteLiteral(@"x, y));  // 1.
                }
            }
            return array;
        },
        // Support iterator within for loops (eventually)
        values: function () {
            __SimpleImageUtilities.funCheck('values', 0, arguments.length);
            return this.toArray();
        },
        // Better name than values if we have to use it
        pixels: function () {
            return this.values();
        },

        // Private methods: should not be called publicly, but it should not hurt if it is
        // Completes the construction of this object once the htmlImage is loaded
        __init: function (img) {
            try {
                this.id = img.id;
                // this is a hack to make three different cases work together:
                // - small empty image, thumbnail images, and canvases
                this.width = ('naturalWidth' in img) ? Math.max(img.naturalWidth, img.width) : img.width;
                this.height = ('naturalHeight' in img) ? Math");
            WriteLiteral(@".max(img.naturalHeight, img.height) : img.height;
                this.canvas.width = this.width;
                this.canvas.height = this.height;
                // are we copying an already loaded image or drawing it fresh
                if (img instanceof HTMLCanvasElement) {
                    var canvasData = img.getContext('2d').getImageData(0, 0, this.width, this.height);
                    this.context.putImageData(canvasData, 0, 0);
                }
                else {
                    this.context.drawImage(img, 0, 0, this.width, this.height);
                }
                this.imageData = this.context.getImageData(0, 0, this.width, this.height);
            }
            catch (err) {
                console.log(err);
                __SimpleImageUtilities.throwError('The name you used to create a SimpleImage was not correct: ' + img.id);
            }
        },
        // computes index into 1-d array, and checks correctness of x,y values
        __getIndex: func");
            WriteLiteral(@"tion (funName, x, y) {
            __SimpleImageUtilities.rangeCheck(x, 0, this.getWidth(), funName, 'x', 'wide');
            __SimpleImageUtilities.rangeCheck(y, 0, this.getHeight(), funName, 'y', 'tall');
            return (Math.floor(x) + Math.floor(y) * this.getWidth()) * 4;
        }
    };


    // Private helper functions, add __ to reduce chance they will conflict with anyone else's method names
    var __SimpleImageUtilities = (function () {
        // private globals
        // image needed to seed ""sized"" image
        var EMPTY_IMAGE_DATA = 'data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAUAAAAFCAQAAAAnZu5uAAAAAXNSR0IArs4c6QAAABVJREFUeJxiYPgPhyQwAQAAAP//AwCgshjoJhZxhgAAAABJRU5ErkJggg==';
        // number of canvases created to hold images
        var globalCanvasCount = 0;
        // load image by wrapping it in an HTML element
        function makeHTMLImage(url, name, simpleImage, loadFunc) {
            if (loadFunc == null) {
                loadFunc = function () {
      ");
            WriteLiteral(@"              simpleImage.__init(this);
                    console.log('loaded image: ' + simpleImage.id);
                }
            }
            var img = new Image();
            img.onload = loadFunc;
            img.src = url;
            img.id = name;
            img.style.display = 'none';
            return img;
        }

        // public utility functions
        return {
            // make a blank image so it is cached for future uses
            EMPTY_IMAGE: makeHTMLImage(EMPTY_IMAGE_DATA, 'EMPTY', null, function () { }),

            // create a canvas element
            makeHTMLCanvas: function (prefix) {
                var canvas = document.createElement('canvas');
                canvas.id = prefix + globalCanvasCount;
                canvas.style.display = 'none';
                canvas.innerHTML = 'Your browser does not support HTML5.'
                globalCanvasCount++;
                return canvas;
            },

            // get image from uploade");
            WriteLiteral(@"d file input
            makeHTMLImageFromInput: function (file, simpleImage) {
                console.log('creating image: ' + file.name);
                var reader = new FileReader();
                reader.onload = function () {
                    makeHTMLImage(this.result, file.name.substr(file.name.lastIndexOf('/') + 1), simpleImage);
                }
                reader.readAsDataURL(file);
                return null;
            },

            // get image from a relative URL
            makeHTMLImageFromURL: function (url, simpleImage) {
                var name = url.substr(0, url.indexOf(';'));
                console.log('creating image: ' + name);
                if (url.substr(0, 4) != 'http') {
                    return makeHTMLImage(url, name, simpleImage);
                }
                else {
                    // does not work --- loading image from URL taints the canvas so we cannot use it :(
                    __SimpleImageUtilities.throwError('Unfortunat");
            WriteLiteral(@"ely you cannot create a SimpleImage directly from a URL: ' + url);
                }
            },

            // create an empty image of the given size
            makeHTMLImageFromSize: function (width, height) {
                console.log('creating image: ' + width + 'x' + height);
                var img = __SimpleImageUtilities.EMPTY_IMAGE.cloneNode(true);
                img.width = width;
                img.height = height;
                return img;
            },

            // set size of the image to the given values, scaling the pixels
            changeSize: function (canvasOld, newWidth, newHeight) {
                var canvasNew = __SimpleImageUtilities.makeHTMLCanvas('setSize_');
                canvasNew.width = newWidth;
                canvasNew.height = newHeight;
                // draw old canvas to new canvas
                var contextNew = canvasNew.getContext('2d');
                contextNew.drawImage(canvasOld, 0, 0, newWidth, newHeight);
               ");
            WriteLiteral(@" return contextNew.getImageData(0, 0, newWidth, newHeight);
            },

            // clamp values to be in the range 0..255
            clamp: function (value) {
                return Math.max(0, Math.min(Math.floor(value), 255));
            },

            // push accumulated local changes out to the screen
            flush: function (context, imageData) {
                if (imageData != null) {
                    context.putImageData(imageData, 0, 0, 0, 0, imageData.width, imageData.height);
                }
            },

            // call this to abort with a message
            throwError: function (message) {
                throw new Error(message);
            },

            // called from user-facing functions to check number of arguments
            funCheck: function (funcName, expectedLen, actualLen) {
                if (expectedLen != actualLen) {
                    var s1 = (actualLen == 1) ? '' : 's';  // pluralize correctly
                    var s2 =");
            WriteLiteral(@" (expectedLen == 1) ? '' : 's';
                    var message = 'You tried to call ' + funcName + ' with ' + actualLen + ' value' + s1 +
                        ', but it expects ' + expectedLen + ' value' + s2 + '.';
                    // someday: think about ""values"" vs. ""arguments"" here
                    __SimpleImageUtilities.throwError(message);
                }
            },

            // called from user-facing functions to check if given value is valid
            rangeCheck: function (value, low, high, funName, coordName, size) {
                if (value < low || value >= high) {
                    var message = 'You tried to call ' + funName + ' for a pixel with ' + coordName + '-coordinate of ' + value +
                        ' in an image that is only ' + high + ' pixels ' + size +
                        ' (valid ' + coordName + ' coordinates are ' + low + ' to ' + (high - 1) + ').';
                    __SimpleImageUtilities.throwError(message);
                }
   ");
            WriteLiteral(@"         }
        };
    })();
    var image = null;
    var borderimage = null;
    function upload() {
        grayimage = new SimpleImage(document.getElementById(""picture""));
        redimage = new SimpleImage(document.getElementById(""picture""));
        rainbowimage = new SimpleImage(document.getElementById(""picture""));
        var canvas = document.getElementById(""pic"");
        var fileinput = document.getElementById(""picture"");
        image = new SimpleImage(fileinput);
        image.drawTo(canvas);
    }

    function makelines() {
        if (image == null) {
            alert('Picture is not loaded');
        }
        else {
            for (var pix1 of borderimage.values()) {
                var canvas = document.getElementById(""pic"");
                var input = document.getElementById(""slider"");
                var line = input.value;
                var context = canvas.getContext(""2d"");
                var height = borderimage.getHeight();
                var width ");
            WriteLiteral(@"= borderimage.getWidth();
                var y = pix1.getY();
                var x = pix1.getX();
                if (x > 0 & x <= line || x < width & x > (width - line)) {
                    pix1.setRed(0);
                    pix1.setGreen(0);
                    pix1.setBlue(0);
                }
            }
        }
        borderimage.drawTo(canvas);
    }

    function changesize() {
        var canvas = document.getElementById(""pic"");
        var input = document.getElementById(""slider"");
        var line = input.value;
        var context = canvas.getContext(""2d"");
    }
    openUploader = function () {
        document.getElementById('uploadImage').click();
    }

    uploadHandler = function () {
        let file = document.querySelector('input[type=file]').files[0];
        let reader = new FileReader();
        let preview = document.getElementById('uploadedImage');


        reader.addEventListener(""load"", function () {
            preview.src = reader.result;");
            WriteLiteral(@"
        }, false);
        if (file) {
            reader.readAsDataURL(file);
            reader.onloadend = function () {
                localStorage.setItem('tempImg', reader.result.split(',')[1]);
            }
        }
    }
    removeImage = function () {
        let preview = document.getElementById('uploadedImage');
        preview.src = '';
    }
</script>
<style>
    nav {
        background-color: snow;
        position: relative;
        margin-top: -10px;
    }

    button {
        position: relative;
        top: 500px;
    }


    #file1 {
        position: relative;
        top: 500px;
    }

    body {
        background-color: lightsalmon;
        background-size: auto;
    }

    .heading {
        font-family: Arial;
        font-size: 32px;
        color: black;
        text-align: center;
    }

    .row {
        display: flex;
    }

    .leftside {
        width: 50%;
        border: 10px solid;
        border-radius: 20px;
      ");
            WriteLiteral(@"  font-family: Arial;
        font-size: 20px;
        text-align: center;
        padding-bottom: 10px;
        position: absolute;
        left: 350px;
        top: 200px;
        background-color: aliceblue;
    }

    canvas {
        height: 210px;
        width: auto;
        border: 5px;
        border-style: double;
        border-radius: 10px;
    }

    .btn {
        background-color: crimson;
        border: none;
        color: white;
        padding: 16px 32px;
        text-align: center;
        font-size: 16px;
        margin: 4px 2px;
        opacity: 0.6;
        transition: 0.3s;
        display: inline-block;
        text-decoration: none;
        cursor: pointer;
    }

        .btn:hover {
            opacity: 1
        }
</style>


<h1 class=""heading"">
</h1>

<div class=""row"">
    <section class=""leftside"">
        <b>Upload photo</b>
        <p>
            <canvas id=""pic"">
            </canvas>
        </p>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1a7de3ff2fe4fc54abbcbed1964cd392ac96b0125675", async() => {
                WriteLiteral("\r\n\r\n            <input type=\"file\" name=\"picture\" accept=\".png*\" id=\"picture\" onchange=\"upload()\">\r\n            <input type=\"submit\" value=\"Upload\" class=\"btn btn-primary\" />\r\n            <div class=\"sub\">\r\n            </div>\r\n\r\n");
#nullable restore
#line 519 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6.cshtml"
             if (ViewData["Picture"] != null)
            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                <img");
                BeginWriteAttribute("src", " src=\"", 20962, "\"", 20992, 2);
                WriteAttributeValue("", 20968, "/MP/", 20968, 4, true);
#nullable restore
#line 522 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6.cshtml"
WriteAttributeValue("", 20972, ViewData["Picture"], 20972, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 523 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 526 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6.cshtml"
             if (ViewData["Message"] != null)
            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                <div");
                BeginWriteAttribute("class", " class=\"", 21101, "\"", 21141, 3);
                WriteAttributeValue("", 21109, "alert", 21109, 5, true);
                WriteAttributeValue(" ", 21114, "alert-", 21115, 7, true);
#nullable restore
#line 529 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6.cshtml"
WriteAttributeValue("", 21121, ViewData["MsgType"], 21121, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <text>");
#nullable restore
#line 530 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6.cshtml"
                     Write(Html.Raw(ViewData["Message"]));

#line default
#line hidden
#nullable disable
                WriteLiteral("</text>\r\n                </div>\r\n");
#nullable restore
#line 532 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </section>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UploadPhoto> Html { get; private set; }
    }
}
#pragma warning restore 1591
