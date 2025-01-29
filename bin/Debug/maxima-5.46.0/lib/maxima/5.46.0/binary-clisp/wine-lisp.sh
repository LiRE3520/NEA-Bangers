#!/bin/sh
# SPDX-License-Identifier: GPL-2.0-or-later
WINEPREFIX=/tmp/maxima-5.46.0/crosscompile-windows/build64/wine
export WINEPREFIX
# do not install (and pop up a window) for Mono and Gecko - not needed.
WINEDLLOVERRIDES="mscoree,mshtml="
export WINEDLLOVERRIDES
unset DISPLAY
/usr/bin/wine64 /tmp/maxima-5.46.0/crosscompile-windows/build64/clisp-prefix/src/clisp/base/lisp.exe "$@"
