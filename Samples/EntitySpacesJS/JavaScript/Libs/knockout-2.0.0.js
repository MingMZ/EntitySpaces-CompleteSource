// Knockout JavaScript library v2.1.0pre
// (c) Steven Sanderson - http://knockoutjs.com/
// License: MIT (http://www.opensource.org/licenses/mit-license.php)

(function (window, document, navigator, undefined) {
    function l(u) { throw u; } var m = void 0, o = !0, p = null, r = !1; function A(u) { return function () { return u } }
    function D(u) {
        function E(b, c, d) { d && c !== a.i.p(b) && a.i.S(b, c); c !== a.i.p(b) && a.a.ta(b, "change") } var a = "undefined" !== typeof u ? u : {}; a.b = function (b, c) { for (var d = b.split("."), e = a, f = 0; f < d.length - 1; f++) e = e[d[f]]; e[d[d.length - 1]] = c }; a.A = function (a, c, d) { a[c] = d }; a.version = "2.1.0pre"; a.b("version", a.version); a.a = new function () {
            function b(a, b) { if ("INPUT" != a.tagName || !a.type || "click" != b.toLowerCase()) return r; var f = a.type.toLowerCase(); return "checkbox" == f || "radio" == f } var c = /^(\s|\u00A0)+|(\s|\u00A0)+$/g, d = {},
e = {}; d[/Firefox\/2/i.test(navigator.userAgent) ? "KeyboardEvent" : "UIEvents"] = ["keyup", "keydown", "keypress"]; d.MouseEvents = "click,dblclick,mousedown,mouseup,mousemove,mouseover,mouseout,mouseenter,mouseleave".split(","); for (var f in d) { var h = d[f]; if (h.length) for (var g = 0, k = h.length; g < k; g++) e[h[g]] = f } var i = function () { for (var a = 3, b = document.createElement("div"), f = b.getElementsByTagName("i"); b.innerHTML = "<\!--[if gt IE " + ++a + "]><i></i><![endif]--\>", f[0]; ); return 4 < a ? a : m } (); return { Aa: ["authenticity_token",
/^__RequestVerificationToken(_.*)?$/], q: function (a, b) { for (var f = 0, e = a.length; f < e; f++) b(a[f]) }, j: function (a, b) { if ("function" == typeof Array.prototype.indexOf) return Array.prototype.indexOf.call(a, b); for (var f = 0, e = a.length; f < e; f++) if (a[f] === b) return f; return -1 }, Xa: function (a, b, f) { for (var e = 0, c = a.length; e < c; e++) if (b.call(f, a[e])) return a[e]; return p }, ba: function (b, f) { var e = a.a.j(b, f); 0 <= e && b.splice(e, 1) }, xa: function (b) { for (var b = b || [], f = [], e = 0, c = b.length; e < c; e++) 0 > a.a.j(f, b[e]) && f.push(b[e]); return f },
    T: function (a, b) { for (var a = a || [], f = [], e = 0, c = a.length; e < c; e++) f.push(b(a[e])); return f }, aa: function (a, b) { for (var a = a || [], f = [], e = 0, c = a.length; e < c; e++) b(a[e]) && f.push(a[e]); return f }, M: function (a, b) { if (b instanceof Array) a.push.apply(a, b); else for (var f = 0, e = b.length; f < e; f++) a.push(b[f]); return a }, extend: function (a, b) { for (var f in b) b.hasOwnProperty(f) && (a[f] = b[f]); return a }, ga: function (b) { for (; b.firstChild; ) a.removeNode(b.firstChild) }, wb: function (b) {
        for (var b = a.a.K(b), f = document.createElement("div"),
e = 0, c = b.length; e < c; e++) f.appendChild(b[e]); return f
    }, Y: function (b, f) { a.a.ga(b); if (f) for (var e = 0, c = f.length; e < c; e++) b.appendChild(f[e]) }, Ja: function (b, f) { var e = b.nodeType ? [b] : b; if (0 < e.length) { for (var c = e[0], h = c.parentNode, d = 0, g = f.length; d < g; d++) h.insertBefore(f[d], c); d = 0; for (g = e.length; d < g; d++) a.removeNode(e[d]) } }, La: function (a, b) { 0 <= navigator.userAgent.indexOf("MSIE 6") ? a.setAttribute("selected", b) : a.selected = b }, v: function (a) { return (a || "").replace(c, "") }, Fb: function (b, f) {
        for (var e = [], c = (b || "").split(f),
h = 0, d = c.length; h < d; h++) { var g = a.a.v(c[h]); "" !== g && e.push(g) } return e
    }, Db: function (a, b) { a = a || ""; return b.length > a.length ? r : a.substring(0, b.length) === b }, $a: function (a, b) { for (var f = "return (" + a + ")", e = 0; e < b; e++) f = "with(sc[" + e + "]) { " + f + " } "; return new Function("sc", f) }, hb: function (a, b) { if (b.compareDocumentPosition) return 16 == (b.compareDocumentPosition(a) & 16); for (; a != p; ) { if (a == b) return o; a = a.parentNode } return r }, fa: function (b) { return a.a.hb(b, document) }, s: function (a, f, e) {
        if ("undefined" != typeof jQuery) {
            if (b(a,
f)) var c = e, e = function (a, b) { var f = this.checked; b && (this.checked = b.ab !== o); c.call(this, a); this.checked = f }; jQuery(a).bind(f, e)
        } else "function" == typeof a.addEventListener ? a.addEventListener(f, e, r) : "undefined" != typeof a.attachEvent ? a.attachEvent("on" + f, function (b) { e.call(a, b) }) : l(Error("Browser doesn't support addEventListener or attachEvent"))
    }, ta: function (a, f) {
        (!a || !a.nodeType) && l(Error("element must be a DOM node when calling triggerEvent")); if ("undefined" != typeof jQuery) {
            var c = []; b(a, f) && c.push({ ab: a.checked });
            jQuery(a).trigger(f, c)
        } else if ("function" == typeof document.createEvent) "function" == typeof a.dispatchEvent ? (c = document.createEvent(e[f] || "HTMLEvents"), c.initEvent(f, o, o, window, 0, 0, 0, 0, 0, r, r, r, r, 0, a), a.dispatchEvent(c)) : l(Error("The supplied element doesn't support dispatchEvent")); else if ("undefined" != typeof a.fireEvent) { if ("click" == f && "INPUT" == a.tagName && ("checkbox" == a.type.toLowerCase() || "radio" == a.type.toLowerCase())) a.checked = a.checked !== o; a.fireEvent("on" + f) } else l(Error("Browser doesn't support triggering events"))
    },
    d: function (b) { return a.V(b) ? b() : b }, gb: function (b, f) { return 0 <= a.a.j((b.className || "").split(/\s+/), f) }, Qa: function (b, f, e) { var c = a.a.gb(b, f); if (e && !c) b.className = (b.className || "") + " " + f; else if (c && !e) { for (var e = (b.className || "").split(/\s+/), c = "", h = 0; h < e.length; h++) e[h] != f && (c += e[h] + " "); b.className = a.a.v(c) } }, Ma: function (b, f) { var e = a.a.d(f); if (e === p || e === m) e = ""; "innerText" in b ? b.innerText = e : b.textContent = e; 9 <= i && (b.style.display = b.style.display) }, ib: function (a) {
        if (9 <= i) {
            var b = a.style.width; a.style.width =
0; a.style.width = b
        } 
    }, Ab: function (b, f) { for (var b = a.a.d(b), f = a.a.d(f), e = [], c = b; c <= f; c++) e.push(c); return e }, K: function (a) { for (var b = [], f = 0, e = a.length; f < e; f++) b.push(a[f]); return b }, pb: 6 === i, qb: 7 === i, nb: i, Ba: function (b, f) { for (var e = a.a.K(b.getElementsByTagName("INPUT")).concat(a.a.K(b.getElementsByTagName("TEXTAREA"))), c = "string" == typeof f ? function (a) { return a.name === f } : function (a) { return f.test(a.name) }, h = [], d = e.length - 1; 0 <= d; d--) c(e[d]) && h.push(e[d]); return h }, xb: function (b) {
        return "string" == typeof b &&
(b = a.a.v(b)) ? window.JSON && window.JSON.parse ? window.JSON.parse(b) : (new Function("return " + b))() : p
    }, qa: function (b) { ("undefined" == typeof JSON || "undefined" == typeof JSON.stringify) && l(Error("Cannot find JSON.stringify(). Some browsers (e.g., IE < 8) don't support it natively, but you can overcome this by adding a script reference to json2.js, downloadable from http://www.json.org/json2.js")); return JSON.stringify(a.a.d(b)) }, yb: function (b, f, e) {
        var e = e || {}, c = e.params || {}, h = e.includeFields || this.Aa, d = b; if ("object" ==
typeof b && "FORM" == b.tagName) for (var d = b.action, g = h.length - 1; 0 <= g; g--) for (var i = a.a.Ba(b, h[g]), k = i.length - 1; 0 <= k; k--) c[i[k].name] = i[k].value; var f = a.a.d(f), v = document.createElement("FORM"); v.style.display = "none"; v.action = d; v.method = "post"; for (var u in f) b = document.createElement("INPUT"), b.name = u, b.value = a.a.qa(a.a.d(f[u])), v.appendChild(b); for (u in c) b = document.createElement("INPUT"), b.name = u, b.value = c[u], v.appendChild(b); document.body.appendChild(v); e.submitter ? e.submitter(v) : v.submit(); setTimeout(function () { v.parentNode.removeChild(v) },
0)
    } 
}
        }; a.b("utils", a.a); a.b("utils.arrayForEach", a.a.q); a.b("utils.arrayFirst", a.a.Xa); a.b("utils.arrayFilter", a.a.aa); a.b("utils.arrayGetDistinctValues", a.a.xa); a.b("utils.arrayIndexOf", a.a.j); a.b("utils.arrayMap", a.a.T); a.b("utils.arrayPushAll", a.a.M); a.b("utils.arrayRemoveItem", a.a.ba); a.b("utils.extend", a.a.extend); a.b("utils.fieldsIncludedWithJsonPost", a.a.Aa); a.b("utils.getFormFields", a.a.Ba); a.b("utils.postJson", a.a.yb); a.b("utils.parseJson", a.a.xb); a.b("utils.registerEventHandler", a.a.s); a.b("utils.stringifyJson",
a.a.qa); a.b("utils.range", a.a.Ab); a.b("utils.toggleDomNodeCssClass", a.a.Qa); a.b("utils.triggerEvent", a.a.ta); a.b("utils.unwrapObservable", a.a.d); Function.prototype.bind || (Function.prototype.bind = function (a) { var c = this, d = Array.prototype.slice.call(arguments), a = d.shift(); return function () { return c.apply(a, d.concat(Array.prototype.slice.call(arguments))) } }); a.a.f = new function () {
    var b = 0, c = "__ko__" + (new Date).getTime(), d = {}; return { get: function (b, f) { var c = a.a.f.getAll(b, r); return c === m ? m : c[f] }, set: function (b,
f, c) { c === m && a.a.f.getAll(b, r) === m || (a.a.f.getAll(b, o)[f] = c) }, getAll: function (a, f) { var h = a[c]; if (!(h && "null" !== h)) { if (!f) return; h = a[c] = "ko" + b++; d[h] = {} } return d[h] }, clear: function (a) { var b = a[c]; b && (delete d[b], a[c] = p) } 
    }
}; a.b("utils.domData", a.a.f); a.b("utils.domData.clear", a.a.f.clear); a.a.D = new function () {
    function b(b, f) { var e = a.a.f.get(b, d); e === m && f && (e = [], a.a.f.set(b, d, e)); return e } function c(e) {
        var d = b(e, r); if (d) for (var d = d.slice(0), k = 0; k < d.length; k++) d[k](e); a.a.f.clear(e); "function" == typeof jQuery &&
"function" == typeof jQuery.cleanData && jQuery.cleanData([e]); if (f[e.nodeType]) for (d = e.firstChild; e = d; ) d = e.nextSibling, 8 === e.nodeType && c(e)
    } var d = "__ko_domNodeDisposal__" + (new Date).getTime(), e = { 1: o, 8: o, 9: o }, f = { 1: o, 9: o }; return { ua: function (a, f) { "function" != typeof f && l(Error("Callback must be a function")); b(a, o).push(f) }, Ia: function (f, e) { var c = b(f, r); c && (a.a.ba(c, e), 0 == c.length && a.a.f.set(f, d, m)) }, I: function (b) {
        if (e[b.nodeType] && (c(b), f[b.nodeType])) {
            var d = []; a.a.M(d, b.getElementsByTagName("*")); for (var b =
0, k = d.length; b < k; b++) c(d[b])
        } 
    }, removeNode: function (b) { a.I(b); b.parentNode && b.parentNode.removeChild(b) } 
    }
}; a.I = a.a.D.I; a.removeNode = a.a.D.removeNode; a.b("cleanNode", a.I); a.b("removeNode", a.removeNode); a.b("utils.domNodeDisposal", a.a.D); a.b("utils.domNodeDisposal.addDisposeCallback", a.a.D.ua); a.b("utils.domNodeDisposal.removeDisposeCallback", a.a.D.Ia); (function () {
    a.a.na = function (b) {
        var c; if ("undefined" != typeof jQuery) {
            if ((c = jQuery.clean([b])) && c[0]) {
                for (b = c[0]; b.parentNode && 11 !== b.parentNode.nodeType; ) b =
b.parentNode; b.parentNode && b.parentNode.removeChild(b)
            } 
        } else { var d = a.a.v(b).toLowerCase(); c = document.createElement("div"); d = d.match(/^<(thead|tbody|tfoot)/) && [1, "<table>", "</table>"] || !d.indexOf("<tr") && [2, "<table><tbody>", "</tbody></table>"] || (!d.indexOf("<td") || !d.indexOf("<th")) && [3, "<table><tbody><tr>", "</tr></tbody></table>"] || [0, "", ""]; b = "ignored<div>" + d[1] + b + d[2] + "</div>"; for ("function" == typeof window.innerShiv ? c.appendChild(window.innerShiv(b)) : c.innerHTML = b; d[0]--; ) c = c.lastChild; c = a.a.K(c.lastChild.childNodes) } return c
    };
    a.a.Z = function (b, c) { a.a.ga(b); if (c !== p && c !== m) if ("string" != typeof c && (c = c.toString()), "undefined" != typeof jQuery) jQuery(b).html(c); else for (var d = a.a.na(c), e = 0; e < d.length; e++) b.appendChild(d[e]) } 
})(); a.b("utils.parseHtmlFragment", a.a.na); a.b("utils.setHtml", a.a.Z); a.r = function () {
    function b() { return (4294967296 * (1 + Math.random()) | 0).toString(16).substring(1) } function c(b, f) {
        if (b) if (8 == b.nodeType) { var d = a.r.Fa(b.nodeValue); d != p && f.push({ fb: b, ub: d }) } else if (1 == b.nodeType) for (var d = 0, g = b.childNodes, k = g.length; d <
k; d++) c(g[d], f)
    } var d = {}; return { la: function (a) { "function" != typeof a && l(Error("You can only pass a function to ko.memoization.memoize()")); var f = b() + b(); d[f] = a; return "<\!--[ko_memo:" + f + "]--\>" }, Ra: function (a, b) { var c = d[a]; c === m && l(Error("Couldn't find any memo with ID " + a + ". Perhaps it's already been unmemoized.")); try { return c.apply(p, b || []), o } finally { delete d[a] } }, Sa: function (b, f) {
        var d = []; c(b, d); for (var g = 0, k = d.length; g < k; g++) {
            var i = d[g].fb, j = [i]; f && a.a.M(j, f); a.r.Ra(d[g].ub, j); i.nodeValue = ""; i.parentNode &&
i.parentNode.removeChild(i)
        } 
    }, Fa: function (a) { return (a = a.match(/^\[ko_memo\:(.*?)\]$/)) ? a[1] : p } 
    }
} (); a.b("memoization", a.r); a.b("memoization.memoize", a.r.la); a.b("memoization.unmemoize", a.r.Ra); a.b("memoization.parseMemoText", a.r.Fa); a.b("memoization.unmemoizeDomNodeAndDescendants", a.r.Sa); a.za = { throttle: function (b, c) { b.throttleEvaluation = c; var d = p; return a.h({ read: b, write: function (a) { clearTimeout(d); d = setTimeout(function () { b(a) }, c) } }) }, notify: function (b, c) {
    b.equalityComparer = "always" == c ? A(r) : a.m.fn.equalityComparer;
    return b
} 
}; a.b("extenders", a.za); a.Oa = function (b, c, d) { this.target = b; this.ca = c; this.eb = d; a.A(this, "dispose", this.z) }; a.Oa.prototype.z = function () { this.ob = o; this.eb() }; a.R = function () { this.u = {}; a.a.extend(this, a.R.fn); a.A(this, "subscribe", this.ra); a.A(this, "extend", this.extend); a.A(this, "getSubscriptionsCount", this.lb) }; a.R.fn = { ra: function (b, c, d) { var d = d || "change", b = c ? b.bind(c) : b, e = new a.Oa(this, b, function () { a.a.ba(this.u[d], e) } .bind(this)); this.u[d] || (this.u[d] = []); this.u[d].push(e); return e }, notifySubscribers: function (b,
c) { c = c || "change"; this.u[c] && a.a.q(this.u[c].slice(0), function (a) { a && a.ob !== o && a.ca(b) }) }, lb: function () { var a = 0, c; for (c in this.u) this.u.hasOwnProperty(c) && (a += this.u[c].length); return a }, extend: function (b) { var c = this; if (b) for (var d in b) { var e = a.za[d]; "function" == typeof e && (c = e(c, b[d])) } return c } 
}; a.Da = function (a) { return "function" == typeof a.ra && "function" == typeof a.notifySubscribers }; a.b("subscribable", a.R); a.b("isSubscribable", a.Da); a.U = function () {
    var b = []; return { Ya: function (a) { b.push({ ca: a, ya: [] }) },
        end: function () { b.pop() }, Ha: function (c) { a.Da(c) || l(Error("Only subscribable things can act as dependencies")); if (0 < b.length) { var d = b[b.length - 1]; 0 <= a.a.j(d.ya, c) || (d.ya.push(c), d.ca(c)) } } 
    }
} (); var F = { undefined: o, "boolean": o, number: o, string: o }; a.m = function (b) {
    function c() { if (0 < arguments.length) { if (!c.equalityComparer || !c.equalityComparer(d, arguments[0])) c.G(), d = arguments[0], c.F(); return this } a.U.Ha(c); return d } var d = b; a.R.call(c); c.F = function () { c.notifySubscribers(d) }; c.G = function () {
        c.notifySubscribers(d,
"beforeChange")
    }; a.a.extend(c, a.m.fn); a.A(c, "valueHasMutated", c.F); a.A(c, "valueWillMutate", c.G); return c
}; a.m.fn = { equalityComparer: function (a, c) { return a === p || typeof a in F ? a === c : r } }; var z = a.m.zb = "__ko_proto__"; a.m.fn[z] = a.m; a.V = function (b) { return b === p || b === m || b[z] === m ? r : b[z] === a.m ? o : a.V(b[z]) }; a.P = function (b) { return "function" == typeof b && b[z] === a.m || "function" == typeof b && b[z] === a.h && b.mb ? o : r }; a.b("observable", a.m); a.b("isObservable", a.V); a.b("isWriteableObservable", a.P); a.Q = function (b) {
    0 == arguments.length &&
(b = []); b !== p && b !== m && !("length" in b) && l(Error("The argument passed when initializing an observable array must be an array, or null, or undefined.")); var c = a.m(b); a.a.extend(c, a.Q.fn); return c
}; a.Q.fn = { remove: function (a) { for (var c = this(), d = [], e = "function" == typeof a ? a : function (f) { return f === a }, f = 0; f < c.length; f++) { var h = c[f]; e(h) && (0 === d.length && this.G(), d.push(h), c.splice(f, 1), f--) } d.length && this.F(); return d }, removeAll: function (b) {
    if (b === m) {
        var c = this(), d = c.slice(0); this.G(); c.splice(0, c.length); this.F();
        return d
    } return !b ? [] : this.remove(function (e) { return 0 <= a.a.j(b, e) })
}, destroy: function (a) { var c = this(), d = "function" == typeof a ? a : function (f) { return f === a }; this.G(); for (var e = c.length - 1; 0 <= e; e--) d(c[e]) && (c[e]._destroy = o); this.F() }, destroyAll: function (b) { return b === m ? this.destroy(A(o)) : !b ? [] : this.destroy(function (c) { return 0 <= a.a.j(b, c) }) }, indexOf: function (b) { var c = this(); return a.a.j(c, b) }, replace: function (a, c) { var d = this.indexOf(a); 0 <= d && (this.G(), this()[d] = c, this.F()) } 
}; a.a.q("pop,push,reverse,shift,sort,splice,unshift".split(","),
function (b) { a.Q.fn[b] = function () { var a = this(); this.G(); a = a[b].apply(a, arguments); this.F(); return a } }); a.a.q(["slice"], function (b) { a.Q.fn[b] = function () { var a = this(); return a[b].apply(a, arguments) } }); a.b("observableArray", a.Q); a.h = function (b, c, d) {
    function e() { a.a.q(t, function (a) { a.z() }); t = [] } function f() { var a = g.throttleEvaluation; a && 0 <= a ? (clearTimeout(y), y = setTimeout(h, a)) : h() } function h() {
        if (j && u()) B(); else {
            try {
                var b = a.a.T(t, function (a) { return a.target }); a.U.Ya(function (e) {
                    var c; 0 <= (c = a.a.j(b, e)) ?
b[c] = m : t.push(e.ra(f))
                }); for (var e = n.call(c), d = b.length - 1; 0 <= d; d--) b[d] && t.splice(d, 1)[0].z(); g.notifySubscribers(i, "beforeChange"); i = e
            } finally { a.U.end() } g.notifySubscribers(i); j = o
        } 
    } function g() { if (0 < arguments.length) k.apply(g, arguments); else return j || h(), a.U.Ha(g), i } function k() { "function" === typeof s ? s.apply(c, arguments) : l(Error("Cannot write a value to a ko.computed unless you specify a 'write' option. If you wish to read the current value, don't pass any parameters.")) } var i, j = r, n = b; n && "object" ==
typeof n ? (d = n, n = d.read) : (d = d || {}, n || (n = d.read)); "function" != typeof n && l(Error("Pass a function that returns the value of the ko.computed")); var s = d.write; c || (c = d.owner); var t = [], B = e, q = "object" == typeof d.disposeWhenNodeIsRemoved ? d.disposeWhenNodeIsRemoved : p, u = d.disposeWhen || A(r); if (q) { B = function () { a.a.D.Ia(q, arguments.callee); e() }; a.a.D.ua(q, B); var x = u, u = function () { return !a.a.fa(q) || x() } } var y = p; g.kb = function () { return t.length }; g.mb = "function" === typeof d.write; g.z = function () { B() }; a.R.call(g); a.a.extend(g,
a.h.fn); d.deferEvaluation !== o && h(); a.A(g, "dispose", g.z); a.A(g, "getDependenciesCount", g.kb); return g
}; u = a.m.zb; a.h[u] = a.m; a.h.fn = {}; a.h.fn[u] = a.h; a.b("dependentObservable", a.h); a.b("computed", a.h); (function () {
    function b(a, f, h) {
        h = h || new d; a = f(a); if (!("object" == typeof a && a !== p && a !== m && !(a instanceof Date))) return a; var g = a instanceof Array ? [] : {}; h.save(a, g); c(a, function (c) {
            var d = f(a[c]); switch (typeof d) {
                case "boolean": case "number": case "string": case "function": g[c] = d; break; case "object": case "undefined": var j =
h.get(d); g[c] = j !== m ? j : b(d, f, h)
            } 
        }); return g
    } function c(a, b) { if (a instanceof Array) { for (var c = 0; c < a.length; c++) b(c); "function" == typeof a.toJSON && b("toJSON") } else for (c in a) b(c) } function d() { var b = [], f = []; this.save = function (c, d) { var k = a.a.j(b, c); 0 <= k ? f[k] = d : (b.push(c), f.push(d)) }; this.get = function (c) { c = a.a.j(b, c); return 0 <= c ? f[c] : m } } a.Pa = function (c) { 0 == arguments.length && l(Error("When calling ko.toJS, pass the object you want to convert.")); return b(c, function (b) { for (var c = 0; a.V(b) && 10 > c; c++) b = b(); return b }) };
    a.toJSON = function (b) { b = a.Pa(b); return a.a.qa(b) } 
})(); a.b("toJS", a.Pa); a.b("toJSON", a.toJSON); (function () {
    a.i = { p: function (b) { return "OPTION" == b.tagName ? b.__ko__hasDomDataOptionValue__ === o ? a.a.f.get(b, a.c.options.ma) : b.getAttribute("value") : "SELECT" == b.tagName ? 0 <= b.selectedIndex ? a.i.p(b.options[b.selectedIndex]) : m : b.value }, S: function (b, c) {
        if ("OPTION" == b.tagName) switch (typeof c) {
            case "string": a.a.f.set(b, a.c.options.ma, m); "__ko__hasDomDataOptionValue__" in b && delete b.__ko__hasDomDataOptionValue__; b.value =
c; break; default: a.a.f.set(b, a.c.options.ma, c), b.__ko__hasDomDataOptionValue__ = o, b.value = "number" === typeof c ? c : ""
        } else if ("SELECT" == b.tagName) for (var d = b.options.length - 1; 0 <= d; d--) { if (a.i.p(b.options[d]) == c) { b.selectedIndex = d; break } } else { if (c === p || c === m) c = ""; b.value = c } 
    } 
    }
})(); a.b("selectExtensions", a.i); a.b("selectExtensions.readValue", a.i.p); a.b("selectExtensions.writeValue", a.i.S); a.k = function () {
    function b(a, b) { for (var e = p; a != e; ) e = a, a = a.replace(c, function (a, f) { return b[f] }); return a } var c = /\@ko_token_(\d+)\@/g,
d = /^[\_$a-z][\_$a-z0-9]*(\[.*?\])*(\.[\_$a-z][\_$a-z0-9]*(\[.*?\])*)*$/i, e = ["true", "false"]; return { C: [], X: function (f) {
    var c = a.a.v(f); if (3 > c.length) return []; "{" === c.charAt(0) && (c = c.substring(1, c.length - 1)); for (var f = [], e = p, d, i = 0; i < c.length; i++) { var j = c.charAt(i); if (e === p) switch (j) { case '"': case "'": case "/": e = i, d = j } else if (j == d && "\\" !== c.charAt(i - 1)) { j = c.substring(e, i + 1); f.push(j); var n = "@ko_token_" + (f.length - 1) + "@", c = c.substring(0, e) + n + c.substring(i + 1), i = i - (j.length - n.length), e = p } } d = e = p; for (var s =
0, t = p, i = 0; i < c.length; i++) { j = c.charAt(i); if (e === p) switch (j) { case "{": e = i; t = j; d = "}"; break; case "(": e = i; t = j; d = ")"; break; case "[": e = i, t = j, d = "]" } j === t ? s++ : j === d && (s--, 0 === s && (j = c.substring(e, i + 1), f.push(j), n = "@ko_token_" + (f.length - 1) + "@", c = c.substring(0, e) + n + c.substring(i + 1), i -= j.length - n.length, e = p)) } d = []; c = c.split(","); e = 0; for (i = c.length; e < i; e++) s = c[e], t = s.indexOf(":"), 0 < t && t < s.length - 1 ? (j = s.substring(t + 1), d.push({ key: b(s.substring(0, t), f), value: b(j, f) })) : d.push({ unknown: b(s, f) }); return d
}, ja: function (b) {
    for (var c =
"string" === typeof b ? a.k.X(b) : b, g = [], b = [], k, i = 0; k = c[i]; i++) if (0 < g.length && g.push(","), k.key) { var j; a: { j = k.key; var n = a.a.v(j); switch (n.length && n.charAt(0)) { case "'": case '"': break a; default: j = "'" + n + "'" } } k = k.value; g.push(j); g.push(":"); g.push(k); n = a.a.v(k); if (0 <= a.a.j(e, a.a.v(n).toLowerCase()) ? 0 : n.match(d) !== p) 0 < b.length && b.push(", "), b.push(j + " : function(__ko_value) { " + k + " = __ko_value; }") } else k.unknown && g.push(k.unknown); c = g.join(""); 0 < b.length && (c = c + ", '_ko_property_writers' : { " + b.join("") +
" } "); return c
}, sb: function (b, c) { for (var e = 0; e < b.length; e++) if (a.a.v(b[e].key) == c) return o; return r } 
}
} (); a.b("jsonExpressionRewriting", a.k); a.b("jsonExpressionRewriting.bindingRewriteValidators", a.k.C); a.b("jsonExpressionRewriting.parseObjectLiteral", a.k.X); a.b("jsonExpressionRewriting.insertPropertyAccessorsIntoJson", a.k.ja); (function () {
    function b(a) { return 8 == a.nodeType && (f ? a.text : a.nodeValue).match(h) } function c(a) { return 8 == a.nodeType && (f ? a.text : a.nodeValue).match(g) } function d(a, f) {
        for (var e =
a, d = 1, g = []; e = e.nextSibling; ) { if (c(e) && (d--, 0 === d)) return g; g.push(e); b(e) && d++ } f || l(Error("Cannot find closing comment tag to match: " + a.nodeValue)); return p
    } function e(a, b) { var c = d(a, b); return c ? 0 < c.length ? c[c.length - 1].nextSibling : a.nextSibling : p } var f = "<\!--test--\>" === document.createComment("test").text, h = f ? /^<\!--\s*ko\s+(.*\:.*)\s*--\>$/ : /^\s*ko\s+(.*\:.*)\s*$/, g = f ? /^<\!--\s*\/ko\s*--\>$/ : /^\s*\/ko\s*$/, k = { ul: o, ol: o }; a.e = { B: {}, childNodes: function (a) { return b(a) ? d(a) : a.childNodes }, ha: function (c) {
        if (b(c)) for (var c =
a.e.childNodes(c), e = 0, f = c.length; e < f; e++) a.removeNode(c[e]); else a.a.ga(c)
    }, Y: function (c, e) { if (b(c)) { a.e.ha(c); for (var f = c.nextSibling, d = 0, g = e.length; d < g; d++) f.parentNode.insertBefore(e[d], f) } else a.a.Y(c, e) }, Ga: function (a, c) { b(a) ? a.parentNode.insertBefore(c, a.nextSibling) : a.firstChild ? a.insertBefore(c, a.firstChild) : a.appendChild(c) }, Ca: function (a, c, e) { b(a) ? a.parentNode.insertBefore(c, e.nextSibling) : e.nextSibling ? a.insertBefore(c, e.nextSibling) : a.appendChild(c) }, firstChild: function (a) {
        return !b(a) ?
a.firstChild : !a.nextSibling || c(a.nextSibling) ? p : a.nextSibling
    }, nextSibling: function (a) { b(a) && (a = e(a)); return a.nextSibling && c(a.nextSibling) ? p : a.nextSibling }, Ta: function (a) { return (a = b(a)) ? a[1] : p }, Ea: function (a) {
        if (k[a.tagName.toLowerCase()]) {
            var f = a.firstChild; if (f) {
                do if (1 === f.nodeType) { var d; d = f.firstChild; var g = p; if (d) { do if (g) g.push(d); else if (b(d)) { var h = e(d, o); h ? d = h : g = [d] } else c(d) && (g = [d]); while (d = d.nextSibling) } if (d = g) { g = f.nextSibling; for (h = 0; h < d.length; h++) g ? a.insertBefore(d[h], g) : a.appendChild(d[h]) } } while (f =
f.nextSibling)
            } 
        } 
    } 
    }
})(); a.b("virtualElements", a.e); a.b("virtualElements.allowedBindings", a.e.B); a.b("virtualElements.emptyNode", a.e.ha); a.b("virtualElements.insertAfter", a.e.Ca); a.b("virtualElements.prepend", a.e.Ga); a.b("virtualElements.setDomNodeChildren", a.e.Y); (function () {
    a.H = function () { this.Za = {} }; a.a.extend(a.H.prototype, { nodeHasBindings: function (b) { switch (b.nodeType) { case 1: return b.getAttribute("data-bind") != p; case 8: return a.e.Ta(b) != p; default: return r } }, getBindings: function (a, c) {
        var d = this.getBindingsString(a,
c); return d ? this.parseBindingsString(d, c) : p
    }, getBindingsString: function (b) { switch (b.nodeType) { case 1: return b.getAttribute("data-bind"); case 8: return a.e.Ta(b); default: return p } }, parseBindingsString: function (b, c) { try { var d = c.$data, d = "object" == typeof d && d != p ? [d, c] : [c], e = d.length, f = this.Za, h = e + "_" + b, g; if (!(g = f[h])) { var k = " { " + a.k.ja(b) + " } "; g = f[h] = a.a.$a(k, e) } return g(d) } catch (i) { l(Error("Unable to parse bindings.\nMessage: " + i + ";\nBindings value: " + b)) } } 
    }); a.H.instance = new a.H
})(); a.b("bindingProvider",
a.H); (function () {
    function b(b, f, d) { for (var g = a.e.firstChild(f); f = g; ) g = a.e.nextSibling(f), c(b, f, d) } function c(c, f, h) { var g = o, k = 1 === f.nodeType; k && a.e.Ea(f); if (k && h || a.H.instance.nodeHasBindings(f)) g = d(f, p, c, h).Cb; g && b(c, f, !k) } function d(b, c, d, g) {
        function k(a) { return function () { return n[a] } } function i() { return n } var j = 0, n, s; a.h(function () {
            var t = d && d instanceof a.w ? d : new a.w(a.a.d(d)), u = t.$data; g && a.Na(b, t); if (n = ("function" == typeof c ? c() : c) || a.H.instance.getBindings(b, t)) {
                if (0 === j) {
                    j = 1; for (var q in n) {
                        var w =
a.c[q]; w && 8 === b.nodeType && !a.e.B[q] && l(Error("The binding '" + q + "' cannot be used with virtual elements")); if (w && "function" == typeof w.init && (w = (0, w.init)(b, k(q), i, u, t)) && w.controlsDescendantBindings) s !== m && l(Error("Multiple bindings (" + s + " and " + q + ") are trying to control descendant bindings of the same element. You cannot use these bindings together on the same element.")), s = q
                    } j = 2
                } if (2 === j) for (q in n) (w = a.c[q]) && "function" == typeof w.update && (0, w.update)(b, k(q), i, u, t)
            } 
        }, p, { disposeWhenNodeIsRemoved: b });
        return { Cb: s === m}
    } a.c = {}; a.w = function (b, c) { c ? (a.a.extend(this, c), this.$parentContext = c, this.$parent = c.$data, this.$parents = (c.$parents || []).slice(0), this.$parents.unshift(this.$parent)) : (this.$parents = [], this.$root = b); this.$data = b }; a.w.prototype.createChildContext = function (b) { return new a.w(b, this) }; a.w.prototype.extend = function (b) { var c = new a.w(this.Eb, this); return a.a.extend(c, b) }; a.Na = function (b, c) { if (2 == arguments.length) a.a.f.set(b, "__ko_bindingContext__", c); else return a.a.f.get(b, "__ko_bindingContext__") };
    a.wa = function (b, c, h) { 1 === b.nodeType && a.e.Ea(b); return d(b, c, h, o) }; a.Ua = function (a, c) { (1 === c.nodeType || 8 === c.nodeType) && b(a, c, o) }; a.va = function (a, b) { b && 1 !== b.nodeType && 8 !== b.nodeType && l(Error("ko.applyBindings: first parameter should be your view model; second parameter should be a DOM node")); b = b || window.document.body; c(a, b, o) }; a.ea = function (b) { switch (b.nodeType) { case 1: case 8: var c = a.Na(b); if (c) return c; if (b.parentNode) return a.ea(b.parentNode) } }; a.cb = function (b) { return (b = a.ea(b)) ? b.$data : m }; a.b("bindingHandlers",
a.c); a.b("applyBindings", a.va); a.b("applyBindingsToDescendants", a.Ua); a.b("applyBindingsToNode", a.wa); a.b("contextFor", a.ea); a.b("dataFor", a.cb)
})(); a.a.q(["click"], function (b) { a.c[b] = { init: function (c, d, e, f) { return a.c.event.init.call(this, c, function () { var a = {}; a[b] = d(); return a }, e, f) } } }); a.c.event = { init: function (b, c, d, e) {
    var f = c() || {}, h; for (h in f) (function () {
        var f = h; "string" == typeof f && a.a.s(b, f, function (b) {
            var h, j = c()[f]; if (j) {
                var n = d(); try { var s = a.a.K(arguments); s.unshift(e); h = j.apply(e, s) } finally {
                    h !==
o && (b.preventDefault ? b.preventDefault() : b.returnValue = r)
                } n[f + "Bubble"] === r && (b.cancelBubble = o, b.stopPropagation && b.stopPropagation())
            } 
        })
    })()
} 
}; a.c.submit = { init: function (b, c, d, e) { "function" != typeof c() && l(Error("The value for a submit binding must be a function")); a.a.s(b, "submit", function (a) { var d, g = c(); try { d = g.call(e, b) } finally { d !== o && (a.preventDefault ? a.preventDefault() : a.returnValue = r) } }) } }; a.c.visible = { update: function (b, c) {
    var d = a.a.d(c()), e = "none" != b.style.display; d && !e ? b.style.display = "" : !d &&
e && (b.style.display = "none")
} 
}; a.c.enable = { update: function (b, c) { var d = a.a.d(c()); d && b.disabled ? b.removeAttribute("disabled") : !d && !b.disabled && (b.disabled = o) } }; a.c.disable = { update: function (b, c) { a.c.enable.update(b, function () { return !a.a.d(c()) }) } }; a.c.value = { init: function (b, c, d) {
    var e = ["change"], f = d().valueUpdate; f && ("string" == typeof f && (f = [f]), a.a.M(e, f), e = a.a.xa(e)); a.a.q(e, function (f) {
        var e = r; a.a.Db(f, "after") && (e = o, f = f.substring(5)); var k = e ? function (a) { setTimeout(a, 0) } : function (a) { a() }; a.a.s(b, f,
function () { k(function () { var f = c(), e = a.i.p(b); a.P(f) ? f(e) : (f = d(), f._ko_property_writers && f._ko_property_writers.value && f._ko_property_writers.value(e)) }) })
    })
}, update: function (b, c) { var d = a.a.d(c()), e = a.i.p(b), f = d != e; 0 === d && 0 !== e && "0" !== e && (f = o); f && (e = function () { a.i.S(b, d) }, e(), "SELECT" == b.tagName && setTimeout(e, 0)); "SELECT" == b.tagName && 0 < b.length && E(b, d, r) } 
}; a.c.options = { update: function (b, c, d) {
    "SELECT" != b.tagName && l(Error("options binding applies only to SELECT elements")); var e = 0 == b.length, f = a.a.T(a.a.aa(b.childNodes,
function (a) { return a.tagName && "OPTION" == a.tagName && a.selected }), function (b) { return a.i.p(b) || b.innerText || b.textContent }), h = b.scrollTop; b.scrollTop = 0; for (var g = a.a.d(c()); 0 < b.length; ) a.I(b.options[0]), b.remove(0); if (g) {
        d = d(); "number" != typeof g.length && (g = [g]); if (d.optionsCaption) { var k = document.createElement("OPTION"); a.a.Z(k, d.optionsCaption); a.i.S(k, m); b.appendChild(k) } for (var c = 0, i = g.length; c < i; c++) {
            var k = document.createElement("OPTION"), j = "string" == typeof d.optionsValue ? g[c][d.optionsValue] : g[c],
j = a.a.d(j); a.i.S(k, j); var n = d.optionsText, j = "function" == typeof n ? n(g[c]) : "string" == typeof n ? g[c][n] : j; if (j === p || j === m) j = ""; a.a.Ma(k, j); b.appendChild(k)
        } g = b.getElementsByTagName("OPTION"); c = k = 0; for (i = g.length; c < i; c++) 0 <= a.a.j(f, a.i.p(g[c])) && (a.a.La(g[c], o), k++); h && (b.scrollTop = h); e && "value" in d && E(b, a.a.d(d.value), o); a.a.ib(b)
    } 
} 
}; a.c.options.ma = "__ko.optionValueDomData__"; a.c.selectedOptions = { ia: function (b) {
    for (var c = [], b = b.childNodes, d = 0, e = b.length; d < e; d++) {
        var f = b[d]; "OPTION" == f.tagName && f.selected ?
c.push(a.i.p(f)) : "OPTGROUP" == f.tagName && (f = a.c.selectedOptions.ia(f), Array.prototype.splice.apply(c, [c.length, 0].concat(f)))
    } return c
}, init: function (b, c, d) { a.a.s(b, "change", function () { var b = c(); a.P(b) ? b(a.c.selectedOptions.ia(this)) : (b = d(), b._ko_property_writers && b._ko_property_writers.value && b._ko_property_writers.value(a.c.selectedOptions.ia(this))) }) }, update: function (b, c) {
    "SELECT" != b.tagName && l(Error("values binding applies only to SELECT elements")); var d = a.a.d(c()); if (d && "number" == typeof d.length) for (var e =
b.childNodes, f = 0, h = e.length; f < h; f++) { var g = e[f]; "OPTION" == g.tagName && a.a.La(g, 0 <= a.a.j(d, a.i.p(g))) } 
} 
}; a.c.text = { update: function (b, c) { a.a.Ma(b, c()) } }; a.c.html = { init: function () { return { controlsDescendantBindings: o} }, update: function (b, c) { var d = a.a.d(c()); a.a.Z(b, d) } }; a.c.css = { update: function (b, c) { var d = a.a.d(c() || {}), e; for (e in d) if ("string" == typeof e) { var f = a.a.d(d[e]); a.a.Qa(b, e, f) } } }; a.c.style = { update: function (b, c) {
    var d = a.a.d(c() || {}), e; for (e in d) if ("string" == typeof e) {
        var f = a.a.d(d[e]); b.style[e] =
f || ""
    } 
} 
}; a.c.uniqueName = { init: function (b, c) { c() && (b.name = "ko_unique_" + ++a.c.uniqueName.bb, (a.a.pb || a.a.qb) && b.mergeAttributes(document.createElement("<input name='" + b.name + "'/>"), r)) } }; a.c.uniqueName.bb = 0; a.c.checked = { init: function (b, c, d) {
    a.a.s(b, "click", function () {
        var e; if ("checkbox" == b.type) e = b.checked; else if ("radio" == b.type && b.checked) e = b.value; else return; var f = c(); "checkbox" == b.type && a.a.d(f) instanceof Array ? (e = a.a.j(a.a.d(f), b.value), b.checked && 0 > e ? f.push(b.value) : !b.checked && 0 <= e && f.splice(e,
1)) : a.P(f) ? f() !== e && f(e) : (f = d(), f._ko_property_writers && f._ko_property_writers.checked && f._ko_property_writers.checked(e))
    }); "radio" == b.type && !b.name && a.c.uniqueName.init(b, A(o))
}, update: function (b, c) { var d = a.a.d(c()); "checkbox" == b.type ? b.checked = d instanceof Array ? 0 <= a.a.j(d, b.value) : d : "radio" == b.type && (b.checked = b.value == d) } 
}; a.c.attr = { update: function (b, c) { var d = a.a.d(c()) || {}, e; for (e in d) if ("string" == typeof e) { var f = a.a.d(d[e]); f === r || f === p || f === m ? b.removeAttribute(e) : b.setAttribute(e, f.toString()) } } };
        a.c.hasfocus = { init: function (b, c, d) { function e(b) { var e = c(); b != a.a.d(e) && (a.P(e) ? e(b) : (e = d(), e._ko_property_writers && e._ko_property_writers.hasfocus && e._ko_property_writers.hasfocus(b))) } a.a.s(b, "focus", function () { e(o) }); a.a.s(b, "focusin", function () { e(o) }); a.a.s(b, "blur", function () { e(r) }); a.a.s(b, "focusout", function () { e(r) }) }, update: function (b, c) { var d = a.a.d(c()); d ? b.focus() : b.blur(); a.a.ta(b, d ? "focusin" : "focusout") } }; a.c["with"] = { n: function (b) { return function () { var c = b(); return { "if": c, data: c, templateEngine: a.o.J} } },
            init: function (b, c) { return a.c.template.init(b, a.c["with"].n(c)) }, update: function (b, c, d, e, f) { return a.c.template.update(b, a.c["with"].n(c), d, e, f) } 
        }; a.k.C["with"] = r; a.e.B["with"] = o; a.c["if"] = { n: function (b) { return function () { return { "if": b(), templateEngine: a.o.J} } }, init: function (b, c) { return a.c.template.init(b, a.c["if"].n(c)) }, update: function (b, c, d, e, f) { return a.c.template.update(b, a.c["if"].n(c), d, e, f) } }; a.k.C["if"] = r; a.e.B["if"] = o; a.c.ifnot = { n: function (b) { return function () { return { ifnot: b(), templateEngine: a.o.J} } },
            init: function (b, c) { return a.c.template.init(b, a.c.ifnot.n(c)) }, update: function (b, c, d, e, f) { return a.c.template.update(b, a.c.ifnot.n(c), d, e, f) } 
        }; a.k.C.ifnot = r; a.e.B.ifnot = o; a.c.foreach = { n: function (b) { return function () { var c = a.a.d(b()); return !c || "number" == typeof c.length ? { foreach: c, templateEngine: a.o.J} : { foreach: c.data, includeDestroyed: c.includeDestroyed, afterAdd: c.afterAdd, beforeRemove: c.beforeRemove, afterRender: c.afterRender, templateEngine: a.o.J} } }, init: function (b, c) { return a.c.template.init(b, a.c.foreach.n(c)) },
            update: function (b, c, d, e, f) { return a.c.template.update(b, a.c.foreach.n(c), d, e, f) } 
        }; a.k.C.foreach = r; a.e.B.foreach = o; a.t = function () { }; a.t.prototype.renderTemplateSource = function () { l(Error("Override renderTemplateSource")) }; a.t.prototype.createJavaScriptEvaluatorBlock = function () { l(Error("Override createJavaScriptEvaluatorBlock")) }; a.t.prototype.makeTemplateSource = function (b) {
            if ("string" == typeof b) { var c = document.getElementById(b); c || l(Error("Cannot find template with ID " + b)); return new a.l.g(c) } if (1 ==
b.nodeType || 8 == b.nodeType) return new a.l.L(b); l(Error("Unknown template type: " + b))
        }; a.t.prototype.renderTemplate = function (a, c, d) { return this.renderTemplateSource(this.makeTemplateSource(a), c, d) }; a.t.prototype.isTemplateRewritten = function (a) { return this.allowTemplateRewriting === r || this.W && this.W[a] ? o : this.makeTemplateSource(a).data("isRewritten") }; a.t.prototype.rewriteTemplate = function (a, c) {
            var d = this.makeTemplateSource(a), e = c(d.text()); d.text(e); d.data("isRewritten", o); "string" == typeof a && (this.W =
this.W || {}, this.W[a] = o)
        }; a.b("templateEngine", a.t); a.$ = function () {
            function b(b, c, d) {
                for (var b = a.k.X(b), g = a.k.C, k = 0; k < b.length; k++) { var i = b[k].key; if (g.hasOwnProperty(i)) { var j = g[i]; "function" === typeof j ? (i = j(b[k].value)) && l(Error(i)) : j || l(Error("This template engine does not support the '" + i + "' binding within its templates")) } } b = "ko.templateRewriting.applyMemoizedBindingsToNextSibling(function() {             return (function() { return { " + a.k.ja(b) + " } })()         })"; return d.createJavaScriptEvaluatorBlock(b) +
c
            } var c = /(<[a-z]+\d*(\s+(?!data-bind=)[a-z0-9\-]+(=(\"[^\"]*\"|\'[^\']*\'))?)*\s+)data-bind=(["'])([\s\S]*?)\5/gi, d = /<\!--\s*ko\b\s*([\s\S]*?)\s*--\>/g; return { jb: function (b, c) { c.isTemplateRewritten(b) || c.rewriteTemplate(b, function (b) { return a.$.vb(b, c) }) }, vb: function (a, f) { return a.replace(c, function (a, c, d, e, j, n, s) { return b(s, c, f) }).replace(d, function (a, c) { return b(c, "<\!-- ko --\>", f) }) }, Va: function (b) { return a.r.la(function (c, d) { c.nextSibling && a.wa(c.nextSibling, b, d) }) } }
        } (); a.b("templateRewriting",
a.$); a.b("templateRewriting.applyMemoizedBindingsToNextSibling", a.$.Va); (function () {
    a.l = {}; a.l.g = function (a) { this.g = a }; a.l.g.prototype.text = function () { if (0 == arguments.length) return "script" == this.g.tagName.toLowerCase() ? this.g.text : this.g.innerHTML; var b = arguments[0]; "script" == this.g.tagName.toLowerCase() ? this.g.text = b : a.a.Z(this.g, b) }; a.l.g.prototype.data = function (b) { if (1 === arguments.length) return a.a.f.get(this.g, "templateSourceData_" + b); a.a.f.set(this.g, "templateSourceData_" + b, arguments[1]) }; a.l.L =
function (a) { this.g = a }; a.l.L.prototype = new a.l.g; a.l.L.prototype.text = function () { if (0 == arguments.length) { var b = a.a.f.get(this.g, "__ko_anon_template__") || {}; b.sa === m && b.da && (b.sa = b.da.innerHTML); return b.sa } a.a.f.set(this.g, "__ko_anon_template__", { sa: arguments[0] }) }; a.l.g.prototype.nodes = function () { if (0 == arguments.length) return (a.a.f.get(this.g, "__ko_anon_template__") || {}).da; a.a.f.set(this.g, "__ko_anon_template__", { da: arguments[0] }) }; a.b("templateSources", a.l); a.b("templateSources.domElement", a.l.g);
    a.b("templateSources.anonymousTemplate", a.l.L)
})(); (function () {
    function b(b, c, d) { for (var e, c = a.e.nextSibling(c); b && (e = b) !== c; ) b = a.e.nextSibling(e), (1 === e.nodeType || 8 === e.nodeType) && d(e) } function c(c, d) { if (c.length) { var e = c[0], k = c[c.length - 1]; b(e, k, function (b) { a.va(d, b) }); b(e, k, function (b) { a.r.Sa(b, [d]) }) } } function d(b, d, g, k, i) {
        var i = i || {}, j = i.templateEngine || e; a.$.jb(g, j); g = j.renderTemplate(g, k, i); ("number" != typeof g.length || 0 < g.length && "number" != typeof g[0].nodeType) && l(Error("Template engine must return an array of DOM nodes"));
        j = r; switch (d) { case "replaceChildren": a.e.Y(b, g); j = o; break; case "replaceNode": a.a.Ja(b, g); j = o; break; case "ignoreTargetNode": break; default: l(Error("Unknown renderMode: " + d)) } j && (c(g, k), i.afterRender && i.afterRender(g, k.$data)); return g
    } var e; a.pa = function (b) { b != m && !(b instanceof a.t) && l(Error("templateEngine must inherit from ko.templateEngine")); e = b }; a.oa = function (b, c, g, k, i) {
        g = g || {}; (g.templateEngine || e) == m && l(Error("Set a template engine before calling renderTemplate")); i = i || "replaceChildren"; if (k) {
            var j =
k.nodeType ? k : 0 < k.length ? k[0] : p; return a.h(function () { var e = c && c instanceof a.w ? c : new a.w(a.a.d(c)), s = "function" == typeof b ? b(e.$data) : b, e = d(k, i, s, e, g); "replaceNode" == i && (k = e, j = k.nodeType ? k : 0 < k.length ? k[0] : p) }, p, { disposeWhen: function () { return !j || !a.a.fa(j) }, disposeWhenNodeIsRemoved: j && "replaceNode" == i ? j.parentNode : j })
        } return a.r.la(function (d) { a.oa(b, c, g, d, "replaceNode") })
    }; a.Bb = function (b, e, g, k, i) {
        function j(a, b) { var d = n(a); c(b, d); g.afterRender && g.afterRender(b, d.$data) } function n(b) { return i.createChildContext(a.a.d(b)) }
        return a.h(function () { var c = a.a.d(e) || []; "undefined" == typeof c.length && (c = [c]); c = a.a.aa(c, function (b) { return g.includeDestroyed || b === m || b === p || !a.a.d(b._destroy) }); a.a.Ka(k, c, function (a) { var c = "function" == typeof b ? b(a) : b; return d(p, "ignoreTargetNode", c, n(a), g) }, g, j) }, p, { disposeWhenNodeIsRemoved: k })
    }; a.c.template = { init: function (b, c) { var d = a.a.d(c()); if ("string" != typeof d && !d.name && (1 == b.nodeType || 8 == b.nodeType)) d = 1 == b.nodeType ? b.childNodes : a.e.childNodes(b), d = a.a.wb(d), (new a.l.L(b)).nodes(d); return { controlsDescendantBindings: o} },
        update: function (b, c, d, e, i) { c = a.a.d(c()); e = o; "string" == typeof c ? d = c : (d = c.name, "if" in c && (e = e && a.a.d(c["if"])), "ifnot" in c && (e = e && !a.a.d(c.ifnot))); var j = p; "object" === typeof c && "foreach" in c ? j = a.Bb(d || b, e && c.foreach || [], c, b, i) : e ? (i = "object" == typeof c && "data" in c ? i.createChildContext(a.a.d(c.data)) : i, j = a.oa(d || b, i, c, b)) : a.e.ha(b); i = j; (c = a.a.f.get(b, "__ko__templateSubscriptionDomDataKey__")) && "function" == typeof c.z && c.z(); a.a.f.set(b, "__ko__templateSubscriptionDomDataKey__", i) } 
    }; a.k.C.template = function (b) {
        b =
a.k.X(b); return 1 == b.length && b[0].unknown || a.k.sb(b, "name") ? p : "This template engine does not support anonymous templates nested within its templates"
    }; a.e.B.template = o
})(); a.b("setTemplateEngine", a.pa); a.b("renderTemplate", a.oa); (function () {
    a.a.N = function (b, c, d) {
        if (d === m) return a.a.N(b, c, 1) || a.a.N(b, c, 10) || a.a.N(b, c, Number.MAX_VALUE); for (var b = b || [], c = c || [], e = b, f = c, h = [], g = 0; g <= f.length; g++) h[g] = []; for (var g = 0, k = Math.min(e.length, d); g <= k; g++) h[0][g] = g; g = 1; for (k = Math.min(f.length, d); g <= k; g++) h[g][0] =
g; for (var k = e.length, i, j = f.length, g = 1; g <= k; g++) { i = Math.max(1, g - d); for (var n = Math.min(j, g + d); i <= n; i++) h[i][g] = e[g - 1] === f[i - 1] ? h[i - 1][g - 1] : Math.min(h[i - 1][g] === m ? Number.MAX_VALUE : h[i - 1][g] + 1, h[i][g - 1] === m ? Number.MAX_VALUE : h[i][g - 1] + 1) } d = b.length; e = c.length; f = []; g = h[e][d]; if (g === m) h = p; else {
            for (; 0 < d || 0 < e; ) {
                k = h[e][d]; j = 0 < e ? h[e - 1][d] : g + 1; n = 0 < d ? h[e][d - 1] : g + 1; i = 0 < e && 0 < d ? h[e - 1][d - 1] : g + 1; if (j === m || j < k - 1) j = g + 1; if (n === m || n < k - 1) n = g + 1; i < k - 1 && (i = g + 1); j <= n && j < i ? (f.push({ status: "added", value: c[e - 1] }), e--) : (n < j && n <
i ? f.push({ status: "deleted", value: b[d - 1] }) : (f.push({ status: "retained", value: b[d - 1] }), e--), d--)
            } h = f.reverse()
        } return h
    } 
})(); a.b("utils.compareArrays", a.a.N); (function () {
    function b(a) { if (2 < a.length) { for (var b = a[0], c = a[a.length - 1], h = [b]; b !== c; ) { b = b.nextSibling; if (!b) return; h.push(b) } Array.prototype.splice.apply(a, [0, a.length].concat(h)) } } function c(c, e, f, h) {
        var g = [], c = a.h(function () { var c = e(f) || []; 0 < g.length && (b(g), a.a.Ja(g, c), h && h(f, c)); g.splice(0, g.length); a.a.M(g, c) }, p, { disposeWhenNodeIsRemoved: c,
            disposeWhen: function () { return 0 == g.length || !a.a.fa(g[0]) } 
        }); return { tb: g, h: c}
    } a.a.Ka = function (d, e, f, h, g) {
        for (var e = e || [], h = h || {}, k = a.a.f.get(d, "setDomNodeChildrenFromArrayMapping_lastMappingResult") === m, i = a.a.f.get(d, "setDomNodeChildrenFromArrayMapping_lastMappingResult") || [], j = a.a.T(i, function (a) { return a.Wa }), n = a.a.N(j, e), e = [], s = 0, t = [], j = [], u = p, q = 0, w = n.length; q < w; q++) switch (n[q].status) {
            case "retained": var x = i[s]; e.push(x); 0 < x.O.length && (u = x.O[x.O.length - 1]); s++; break; case "deleted": i[s].h.z(); b(i[s].O);
                a.a.q(i[s].O, function (a) { t.push({ element: a, index: q, value: n[q].value }); u = a }); s++; break; case "added": var x = n[q].value, y = c(d, f, x, g), v = y.tb; e.push({ Wa: n[q].value, O: v, h: y.h }); for (var y = 0, z = v.length; y < z; y++) { var C = v[y]; j.push({ element: C, index: q, value: n[q].value }); u == p ? a.e.Ga(d, C) : a.e.Ca(d, C, u); u = C } g && g(x, v)
        } a.a.q(t, function (b) { a.I(b.element) }); f = r; if (!k) {
            if (h.afterAdd) for (q = 0; q < j.length; q++) h.afterAdd(j[q].element, j[q].index, j[q].value); if (h.beforeRemove) {
                for (q = 0; q < t.length; q++) h.beforeRemove(t[q].element,
t[q].index, t[q].value); f = o
            } 
        } f || a.a.q(t, function (b) { a.removeNode(b.element) }); a.a.f.set(d, "setDomNodeChildrenFromArrayMapping_lastMappingResult", e)
    } 
})(); a.b("utils.setDomNodeChildrenFromArrayMapping", a.a.Ka); a.o = function () { this.allowTemplateRewriting = r }; a.o.prototype = new a.t; a.o.prototype.renderTemplateSource = function (b) { var c = !(9 > a.a.nb) && b.nodes ? b.nodes() : p; if (c) return a.a.K(c.cloneNode(o).childNodes); b = b.text(); return a.a.na(b) }; a.o.J = new a.o; a.pa(a.o.J); a.b("nativeTemplateEngine", a.o); (function () {
    a.ka =
function () {
    var a = this.rb = function () { if ("undefined" == typeof jQuery || !jQuery.tmpl) return 0; try { if (0 <= jQuery.tmpl.tag.tmpl.open.toString().indexOf("__")) return 2 } catch (a) { } return 1 } (); this.renderTemplateSource = function (b, e, f) {
        f = f || {}; 2 > a && l(Error("Your version of jQuery.tmpl is too old. Please upgrade to jQuery.tmpl 1.0.0pre or later.")); var h = b.data("precompiled"); h || (h = b.text() || "", h = jQuery.template(p, "{{ko_with $item.koBindingContext}}" + h + "{{/ko_with}}"), b.data("precompiled", h)); b = [e.$data]; e = jQuery.extend({ koBindingContext: e },
f.templateOptions); e = jQuery.tmpl(h, b, e); e.appendTo(document.createElement("div")); jQuery.fragments = {}; return e
    }; this.createJavaScriptEvaluatorBlock = function (a) { return "{{ko_code ((function() { return " + a + " })()) }}" }; this.addTemplate = function (a, b) { document.write("<script type='text/html' id='" + a + "'>" + b + "<\/script>") }; 0 < a && (jQuery.tmpl.tag.ko_code = { open: "__.push($1 || '');" }, jQuery.tmpl.tag.ko_with = { open: "with($1) {", close: "} " })
}; a.ka.prototype = new a.t; var b = new a.ka; 0 < b.rb && a.pa(b); a.b("jqueryTmplTemplateEngine",
a.ka)
})()
    } "function" === typeof require && "object" === typeof exports && "object" === typeof module ? D(module.exports || exports) : "function" === typeof define && define.amd ? define(["exports"], D) : D(window.ko = {}); o;
})(window, document, navigator);                  
