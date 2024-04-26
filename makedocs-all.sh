#! /usr/bin/env bash
files=$(find . -name "makedocs.sh")
for file in $files; do 
  dir=$(dirname "$file")
  pushd "$dir" || continue 
  # shellcheck disable=SC1090
  ./makedocs.sh
  popd || return 
done