#!/bin/bash
ver=$(gitversion)
echo $ver | sed -n 's|.*"SemVer":"\([^"]*\)".*|\1|p'
